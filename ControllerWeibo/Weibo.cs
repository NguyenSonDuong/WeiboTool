using ModelWeibo.Recieve;
using Newtonsoft.Json;
using System;
using xNet;

namespace ControllerWeibo
{
    public delegate void ProcessLoading(Object data);
    public delegate void SuccessLoadig(Object data);
    public delegate void ErrorLoading(Object data);
    public class Weibo
    {
        public static String URI = "https://m.weibo.cn/api/container/getIndex?";

        private String idUser;
        private String userName;
        private bool isStop = false;

        private event ProcessLoading processLoading;
        private event SuccessLoadig successLoading;
        private event ErrorLoading errorLoading;

        public event ProcessLoading ProcessLoading{
            add { this.processLoading += value; }
            remove { this.processLoading -= value; }
        }
        public event SuccessLoadig SuccessLoading{
            add { this.successLoading += value; }
            remove { this.successLoading -= value; }
        }
        public event ErrorLoading ErrorLoading{
            add { this.errorLoading += value; }
            remove { this.errorLoading -= value; }
        }

        public string IdUser { get => idUser; set => idUser = value; }
        public string UserName { get => userName; set => userName = value; }
        public bool IsStop { get => isStop; set => isStop = value; }

        public String GetValue(String since_id)
        {
            return $"type=uid&value={idUser}&containerid=107603{idUser}&since_id={since_id}";
        }

        public void GetListPostOfUser(String since_id = "")
        {
            try
            {
                String url = URI + GetValue(since_id);
                String json = RequestCustom.GET(url,"",Http.ChromeUserAgent());
                PostInfoRecieve.Rootobject rootobject = JsonConvert.DeserializeObject<PostInfoRecieve.Rootobject>(json);
                foreach(PostInfoRecieve.Card item in rootobject.data.cards)
                {
                    if (!isStop)
                        processLoading(item);
                    else
                    {
                        successLoading("Đã tải thành công dữ liệu");
                        return;
                    }
                        
                }
                if(rootobject.data.cardlistInfo != null )
                {
                    if(rootobject.data.cardlistInfo.since_id != null )
                    {
                        GetListPostOfUser(rootobject.data.cardlistInfo.since_id + "");
                    }
                    else
                    {
                        successLoading("Đã tải thành công dữ liệu");
                        return;
                    }
                }
                else
                {
                    successLoading("Đã tải thành công dữ liệu");
                    return;
                }
            }catch(Exception ex)
            {
                errorLoading(ex);
            }
        }
    }
}

using ModelWeibo.Recieve;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ControllerWeibo
{
    public delegate void ErrorAction(Object ex);
    public class ActionWeiboAsync
    {
        public static async Task ActionLoadPostUser(Weibo weibo)
        {
            await Task.Run(() =>
            {
                weibo.GetListPostOfUser();
            });
        }
        public static void ActionDownload(PostInfoRecieve.Card card, String path,bool isLarge, ErrorAction error, ProcessLoading process)
        {
            try
            {
                if (card.mblog.page_info != null)
                {
                    if (card.mblog.page_info.media_info != null)
                    {
                        RequestCustom.DOWNLOAD(card.mblog.page_info.media_info.mp4_hd_url, path + card.mblog.page_info.media_info.media_id + ".mp4", "", "");
                        process(card.mblog.page_info.media_info.media_id);
                    }
                        
                }
                if (card.mblog.pics != null)
                {
                    foreach (PostInfoRecieve.Pic1 item in card.mblog.pics)
                    {
                        if (isLarge)
                            RequestCustom.DOWNLOAD(item.large.url, path + item.pid + ".png", "", "");
                        else
                            RequestCustom.DOWNLOAD(item.url, path + item.pid + ".png", "", "");
                        process(item.pid);
                    }
                }
            }
            catch(Exception ex)
            {
                error(ex.Message);
            }
        }

    }
}

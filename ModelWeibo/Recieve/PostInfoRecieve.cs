using System;
using System.Collections.Generic;
using System.Text;

namespace ModelWeibo.Recieve
{
    public class PostInfoRecieve
    {

        public class Rootobject
        {
            public int ok { get; set; }
            public Data data { get; set; }
        }

        public class Data
        {
            public Cardlistinfo cardlistInfo { get; set; }
            public Card[] cards { get; set; }
            public object banners { get; set; }
            public string scheme { get; set; }
            public int showAppTips { get; set; }
        }

        public class Cardlistinfo
        {
            public string containerid { get; set; }
            public int v_p { get; set; }
            public int show_style { get; set; }
            public int total { get; set; }
            public Int64 since_id { get; set; }
        }

        public class Card
        {
            public int card_type { get; set; }
            public string itemid { get; set; }
            public string scheme { get; set; }
            public Mblog mblog { get; set; }
            public int show_type { get; set; }
        }

        public class Mblog
        {
            public Visible visible { get; set; }
            public string created_at { get; set; }
            public string id { get; set; }
            public string idstr { get; set; }
            public string mid { get; set; }
            public bool can_edit { get; set; }
            public int version { get; set; }
            public int show_additional_indication { get; set; }
            public string text { get; set; }
            public int textLength { get; set; }
            public string source { get; set; }
            public bool favorited { get; set; }
            public string pic_types { get; set; }
            public string thumbnail_pic { get; set; }
            public string bmiddle_pic { get; set; }
            public string original_pic { get; set; }
            public bool is_paid { get; set; }
            public int mblog_vip_type { get; set; }
            public User user { get; set; }
            public string picStatus { get; set; }
            public int reposts_count { get; set; }
            public int comments_count { get; set; }
            public int attitudes_count { get; set; }
            public int pending_approval_count { get; set; }
            public bool isLongText { get; set; }
            public int reward_exhibition_type { get; set; }
            public string reward_scheme { get; set; }
            public int hide_flag { get; set; }
            public int mlevel { get; set; }
            public int expire_time { get; set; }
            public int ad_state { get; set; }
            public int mblogtype { get; set; }
            public string mark { get; set; }
            public string rid { get; set; }
            public int more_info_type { get; set; }
            public int extern_safe { get; set; }
            public Number_Display_Strategy number_display_strategy { get; set; }
            public bool enable_comment_guide { get; set; }
            public int content_auth { get; set; }
            public int pic_num { get; set; }
            public Alchemy_Params alchemy_params { get; set; }
            public int mblog_menu_new_style { get; set; }
            public Edit_Config edit_config { get; set; }
            public int weibo_position { get; set; }
            public int show_attitude_bar { get; set; }
            public string readtimetype { get; set; }
            public string raw_text { get; set; }
            public string bid { get; set; }
            public Pic1[] pics { get; set; }
            public int edit_count { get; set; }
            public string edit_at { get; set; }
            public Retweeted_Status retweeted_status { get; set; }
            public int repost_type { get; set; }
            public long fid { get; set; }
            public string obj_ext { get; set; }
            public Page_Info page_info { get; set; }
        }

        public class Visible
        {
            public int type { get; set; }
            public int list_id { get; set; }
        }

        public class User
        {
            public Int64 id { get; set; }
            public string screen_name { get; set; }
            public string profile_image_url { get; set; }
            public string profile_url { get; set; }
            public int statuses_count { get; set; }
            public bool verified { get; set; }
            public int verified_type { get; set; }
            public int verified_type_ext { get; set; }
            public string verified_reason { get; set; }
            public bool close_blue_v { get; set; }
            public string description { get; set; }
            public string gender { get; set; }
            public int mbtype { get; set; }
            public int urank { get; set; }
            public int mbrank { get; set; }
            public bool follow_me { get; set; }
            public bool following { get; set; }
            public int followers_count { get; set; }
            public int follow_count { get; set; }
            public string cover_image_phone { get; set; }
            public string avatar_hd { get; set; }
            public bool like { get; set; }
            public bool like_me { get; set; }
            public Badge badge { get; set; }
        }

        public class Badge
        {
            public int anniversary { get; set; }
            public int bind_taobao { get; set; }
            public int self_media { get; set; }
            public int dzwbqlx_2016 { get; set; }
            public int follow_whitelist_video { get; set; }
            public int lol_gm_2017 { get; set; }
            public int user_name_certificate { get; set; }
            public int hongbaofei_2019 { get; set; }
            public int hongbao_2020 { get; set; }
            public int pc_new { get; set; }
        }

        public class Number_Display_Strategy
        {
            public int apply_scenario_flag { get; set; }
            public int display_text_min_number { get; set; }
            public string display_text { get; set; }
        }

        public class Alchemy_Params
        {
            public bool ug_red_envelope { get; set; }
        }

        public class Edit_Config
        {
            public bool edited { get; set; }
            public Menu_Edit_History menu_edit_history { get; set; }
        }

        public class Menu_Edit_History
        {
            public string scheme { get; set; }
            public string title { get; set; }
        }

        public class Retweeted_Status
        {
            public Visible1 visible { get; set; }
            public string created_at { get; set; }
            public string id { get; set; }
            public string idstr { get; set; }
            public string mid { get; set; }
            public bool can_edit { get; set; }
            public int version { get; set; }
            public int show_additional_indication { get; set; }
            public string text { get; set; }
            public int textLength { get; set; }
            public string source { get; set; }
            public bool favorited { get; set; }
            public string pic_types { get; set; }
            public string thumbnail_pic { get; set; }
            public string bmiddle_pic { get; set; }
            public string original_pic { get; set; }
            public bool is_paid { get; set; }
            public int mblog_vip_type { get; set; }
            public User1 user { get; set; }
            public string picStatus { get; set; }
            public int reposts_count { get; set; }
            public int comments_count { get; set; }
            public int attitudes_count { get; set; }
            public int pending_approval_count { get; set; }
            public bool isLongText { get; set; }
            public int reward_exhibition_type { get; set; }
            public int hide_flag { get; set; }
            public int mlevel { get; set; }
            public int mblogtype { get; set; }
            public string rid { get; set; }
            public int more_info_type { get; set; }
            public Number_Display_Strategy1 number_display_strategy { get; set; }
            public int content_auth { get; set; }
            public int pic_num { get; set; }
            public Edit_Config1 edit_config { get; set; }
            public int weibo_position { get; set; }
            public int show_attitude_bar { get; set; }
            public int retweeted { get; set; }
            public string raw_text { get; set; }
            public string bid { get; set; }
            public Pic[] pics { get; set; }
        }

        public class Visible1
        {
            public int type { get; set; }
            public int list_id { get; set; }
        }

        public class User1
        {
            public int id { get; set; }
            public string screen_name { get; set; }
            public string profile_image_url { get; set; }
            public string profile_url { get; set; }
            public int statuses_count { get; set; }
            public bool verified { get; set; }
            public int verified_type { get; set; }
            public int verified_type_ext { get; set; }
            public string verified_reason { get; set; }
            public bool close_blue_v { get; set; }
            public string description { get; set; }
            public string gender { get; set; }
            public int mbtype { get; set; }
            public int urank { get; set; }
            public int mbrank { get; set; }
            public bool follow_me { get; set; }
            public bool following { get; set; }
            public int followers_count { get; set; }
            public int follow_count { get; set; }
            public string cover_image_phone { get; set; }
            public string avatar_hd { get; set; }
            public bool like { get; set; }
            public bool like_me { get; set; }
            public Badge1 badge { get; set; }
        }

        public class Badge1
        {
            public int anniversary { get; set; }
            public int bind_taobao { get; set; }
            public int self_media { get; set; }
            public int dzwbqlx_2016 { get; set; }
            public int follow_whitelist_video { get; set; }
            public int lol_gm_2017 { get; set; }
            public int user_name_certificate { get; set; }
            public int hongbaofei_2019 { get; set; }
            public int hongbao_2020 { get; set; }
            public int pc_new { get; set; }
        }

        public class Number_Display_Strategy1
        {
            public int apply_scenario_flag { get; set; }
            public int display_text_min_number { get; set; }
            public string display_text { get; set; }
        }

        public class Edit_Config1
        {
            public bool edited { get; set; }
        }

        public class Pic
        {
            public string pid { get; set; }
            public string url { get; set; }
            public string size { get; set; }
            public Geo geo { get; set; }
            public Large large { get; set; }
        }

        public class Geo
        {
            public int width { get; set; }
            public int height { get; set; }
            public bool croped { get; set; }
        }

        public class Large
        {
            public string size { get; set; }
            public string url { get; set; }
            public Geo1 geo { get; set; }
        }

        public class Geo1
        {
            public string width { get; set; }
            public string height { get; set; }
            public bool croped { get; set; }
        }

        public class Page_Info
        {
            public Page_Pic page_pic { get; set; }
            public string page_url { get; set; }
            public string page_title { get; set; }
            public string content1 { get; set; }
            public string content2 { get; set; }
            public string type { get; set; }
            public Media_Info media_info { get; set; }
            public string play_count { get; set; }
            public string object_id { get; set; }
        }

        public class Page_Pic
        {
            public string url { get; set; }
        }

        public class Media_Info
        {
            public string video_orientation { get; set; }
            public string name { get; set; }
            public string stream_url { get; set; }
            public string stream_url_hd { get; set; }
            public string h5_url { get; set; }
            public string mp4_sd_url { get; set; }
            public string mp4_hd_url { get; set; }
            public string h265_mp4_hd { get; set; }
            public string h265_mp4_ld { get; set; }
            public string inch_4_mp4_hd { get; set; }
            public string inch_5_mp4_hd { get; set; }
            public string inch_5_5_mp4_hd { get; set; }
            public string mp4_720p_mp4 { get; set; }
            public string hevc_mp4_720p { get; set; }
            public int prefetch_type { get; set; }
            public int prefetch_size { get; set; }
            public int act_status { get; set; }
            public string protocol { get; set; }
            public string media_id { get; set; }
            public int origin_total_bitrate { get; set; }
            public int duration { get; set; }
            public int forward_strategy { get; set; }
            public string search_scheme { get; set; }
            public int is_short_video { get; set; }
            public string next_title { get; set; }
            public string hevc_mp4_hd { get; set; }
            public Play_Completion_Actions[] play_completion_actions { get; set; }
            public int video_publish_time { get; set; }
            public int play_loop_type { get; set; }
            public string author_mid { get; set; }
            public string author_name { get; set; }
            public Extra_Info extra_info { get; set; }
            public int has_recommend_video { get; set; }
            public Video_Download_Strategy video_download_strategy { get; set; }
            public int jump_to { get; set; }
            public string online_users { get; set; }
            public int online_users_number { get; set; }
            public int ttl { get; set; }
            public string storage_type { get; set; }
            public int is_keep_current_mblog { get; set; }
        }

        public class Extra_Info
        {
            public string sceneid { get; set; }
        }

        public class Video_Download_Strategy
        {
            public int abandon_download { get; set; }
        }

        public class Play_Completion_Actions
        {
            public string type { get; set; }
            public string icon { get; set; }
            public string text { get; set; }
            public string link { get; set; }
            public int btn_code { get; set; }
            public int show_position { get; set; }
            public Actionlog actionlog { get; set; }
        }

        public class Actionlog
        {
            public string oid { get; set; }
            public int act_code { get; set; }
            public int act_type { get; set; }
            public string source { get; set; }
        }

        public class Pic1
        {
            public string pid { get; set; }
            public string url { get; set; }
            public string size { get; set; }
            public Geo2 geo { get; set; }
            public Large1 large { get; set; }
        }

        public class Geo2
        {
            public int width { get; set; }
            public int height { get; set; }
            public bool croped { get; set; }
        }

        public class Large1
        {
            public string size { get; set; }
            public string url { get; set; }
            public Geo3 geo { get; set; }
        }

        public class Geo3
        {
            public object width { get; set; }
            public object height { get; set; }
            public bool croped { get; set; }
        }


    }
}

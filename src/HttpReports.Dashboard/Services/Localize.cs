using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace HttpReports.Dashboard.Services
{
    public class Localize
    {
        private readonly IDictionary<string, string> _resource;
         
        public string ServiceTag => GetValue();

        public string InstanceTag => GetValue();

        public string AvgProcessingTime => GetValue();
        public string Back => GetValue();
        public string Button_Cancel => GetValue();

        public string Granularity => GetValue();

        public string TimeRangeFormatError => GetValue();


        public string Granularity_10Second => GetValue();

        public string Granularity_1Minute => GetValue();

        public string Granularity_5Minute => GetValue();


        public string Button_OK => GetValue();
        public string EndTime => GetValue();
        public string Index_APICount => GetValue();
        public string Index_ART => GetValue();
        public string Index_ErrorPercent => GetValue();
        public string Index_Fast => GetValue();
        public string Index_NewPwd => GetValue();
        public string Index_OldPwd => GetValue();
        public string Index_RequestCount => GetValue();
        public string Index_SelectCount => GetValue();
        public string Index_ServiceNode => GetValue();
        public string Index_ServiceNodeTip => GetValue();
        public string Index_Slow => GetValue();
        public string Index_UserSave => GetValue();
        public string Language => GetValue();

        public string LanguageFormat => GetValue();
        public string Login_Button => GetValue();
        public string Login_CheckRule => GetValue();
        public string Login_Password => GetValue();
        public string Login_Success => GetValue();
        public string Login_UserName => GetValue();
        public string Login_UserOrPassError => GetValue();
        public string Menu_BasicData => GetValue();
        public string Menu_Monitor => GetValue();

        public string Performance => GetValue();

        public string Menu_RequestList => GetValue();
        public string Menu_TrendData => GetValue();
        public string Monitor_Add => GetValue();
        public string Monitor_CheckBox_Close => GetValue();
        public string Monitor_CheckBox_Open => GetValue();
        public string Monitor_ConfirmDelete => GetValue();
        public string Monitor_ConfirmStart => GetValue();
        public string Monitor_ConfirmStop => GetValue();
        public string Monitor_Delete => GetValue();
        public string Monitor_DeleteSuccess => GetValue();
        public string Monitor_Desc_Placeholder => GetValue();
        public string Monitor_Description => GetValue();
        public string Monitor_DescTooLong => GetValue();
        public string Monitor_Edit => GetValue();
        public string Monitor_Email => GetValue();
        public string Monitor_Email_Placeholder => GetValue();
        public string Monitor_EmailOrWebHookNotNull => GetValue();
        public string Monitor_EmailTooLong => GetValue();
        public string Monitor_Error_PercnetError => GetValue();
        public string Monitor_Error_StatusCodeNotNull => GetValue();
        public string Monitor_Error_StatusCodeTooLong => GetValue();
        public string Monitor_Frequency => GetValue();
        public string Monitor_HttpStatusCode => GetValue();
        public string Monitor_HttpStatusCode_Desc => GetValue();
        public string Monitor_IP_Desc => GetValue();
        public string Monitor_IP_Info => GetValue();
        public string Monitor_IP_PercentError => GetValue();
        public string Monitor_IP_WhiteListTooLong => GetValue();
        public string Monitor_IPWhiteList => GetValue();
        public string Monitor_IPWhiteList_Placeholder => GetValue();
        public string Monitor_Max_Request => GetValue();
        public string Monitor_MustSelectNode => GetValue();
        public string Monitor_MustSelectType => GetValue();
        public string Monitor_NavTitle => GetValue();
        public string Monitor_Operation => GetValue();
        public string Monitor_Push_Placeholder => GetValue();
        public string Monitor_PushUrl => GetValue();
        public string Monitor_Request_FormatError => GetValue();
        public string Monitor_Runing => GetValue();
        public string Monitor_ServiceNode => GetValue();
        public string Monitor_InstanceName => GetValue();
        public string Monitor_Start => GetValue();
        public string Monitor_State => GetValue();
        public string Monitor_Stop => GetValue();
        public string Monitor_Stoping => GetValue();
        public string Monitor_Task => GetValue();
        public string Monitor_Time10Min => GetValue();
        public string Monitor_Time12Hour => GetValue();
        public string Monitor_Time1Day => GetValue();
        public string Monitor_Time1Hour => GetValue();
        public string Monitor_Time1Min => GetValue();
        public string Monitor_Time2Hour => GetValue();
        public string Monitor_Time30Min => GetValue();
        public string Monitor_Time3Min => GetValue();
        public string Monitor_Time4Hour => GetValue();
        public string Monitor_Time5Min => GetValue();
        public string Monitor_Time6Hour => GetValue();
        public string Monitor_Time8Hour => GetValue();
        public string Monitor_Timeout => GetValue();
        public string Monitor_Timeout_Description => GetValue();
        public string Monitor_Timeout_Info => GetValue();
        public string Monitor_Timeout_Percentage => GetValue();
        public string Monitor_TimeOut_PercnetError => GetValue();
        public string Monitor_TimeOut_TimeFormatError => GetValue();
        public string Monitor_Title => GetValue();
        public string Monitor_Title_Placeholder => GetValue();
        public string Monitor_TitleNotNull => GetValue();
        public string Monitor_TitleTooLong => GetValue();
        public string Monitor_Type_IP => GetValue();
        public string Monitor_Type_RequestCount => GetValue();
        public string Monitor_Type_RequestCount_Desc => GetValue();
        public string Monitor_Type_RequestCount_Info => GetValue();
        public string Monitor_Type_RequestError => GetValue();

        public string To => GetValue();

        public string Monitor_Type_RequestError_Desc => GetValue();
        public string Monitor_Type_RequestError_Info => GetValue();
        public string Monitor_Type_Timeout => GetValue();
        public string Monitor_UpdateSuccess => GetValue();
        public string Monitor_WebHookTooLong => GetValue();
        public string Mostrequests => GetValue();
        public string ProcessingTime => GetValue();
        public string ProcessingTime2 => GetValue();
        public string Query => GetValue();
        public string Request_BasicInfo => GetValue();
        public string Request_Connection => GetValue();
        public string Request_CreateTime => GetValue();
        public string Request_DetailInfo => GetValue();
        public string Request_IPAddress => GetValue();
        public string Request_LocalIP => GetValue();
        public string Request_LocalPort => GetValue();
        public string Request_NotFound => GetValue();
        public string Request_RemoteIP => GetValue();
        public string Request_RemotePort => GetValue();
        public string Request_RequestUrl => GetValue();
        public string Request_Route => GetValue();
        public string Request_StatusCode => GetValue();
        public string Request_Time => GetValue();
        public string Request_Trace => GetValue();
        public string Request_Type => GetValue();
        public string Request_Url => GetValue();
        public string RequestError => GetValue();
        public string Save => GetValue();
        public string Save_Success => GetValue();
        public string StartTime => GetValue();
        public string StatusCode => GetValue();
        public string Task => GetValue();
        public string Template_Dark => GetValue();
        public string Template_EditAccount => GetValue();
        public string Template_Light => GetValue();
        public string Template_Logout => GetValue();
        public string Time_12h => GetValue();
        public string Time_15m => GetValue();
        public string Time_1h => GetValue();
        public string Time_24h => GetValue();
        public string Time_30m => GetValue();
        public string Time_4h => GetValue();
        public string TimeNotNull => GetValue();
        public string Trend_DayTotalCount => GetValue();
        public string Trend_HourAvgTime => GetValue();
        public string Trend_HourTotalCount => GetValue();
        public string Trend_MinuteAvgTime => GetValue();
        public string Trend_MinuteTotalCount => GetValue();
        public string UpdateSuccess => GetValue();
        public string User_AccountFormatError => GetValue();
        public string User_NewPassFormatError => GetValue();
        public string User_NotNull => GetValue();
        public string User_OldNewPass => GetValue();
        public string User_OldPasswordError => GetValue();
        public string User_UpdateSuccess => GetValue();
        public string Warning_Current => GetValue();
        public string Warning_Threshold => GetValue();

        public string Min => GetValue();

        public string Max => GetValue();


        public string Warning_TimeRange => GetValue();
        public string Warning_Title => GetValue();

        public string HeapMemory => GetValue();

        public string ProcessCPU => GetValue();

        public string ProcessMemory => GetValue();

        public string ThreadCount => GetValue();


        public string RequestBody => GetValue();

        public string ResponseBody => GetValue(); 


        public string this[string key] => _resource.TryGetValue(key, out var value) ? value : string.Empty;

        protected string GetValue([CallerMemberName]string key = "") => this[key];

        public Localize(IDictionary<string, string> resource)
        {
            _resource = resource ?? throw new ArgumentNullException(nameof(resource));
        }
    }
}

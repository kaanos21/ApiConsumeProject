namespace HotelProject.WebUI.Dtos.SendMessageDto
{
    public class ResultSendboxDto
    {
        public int SendMessageID { get; set; }
        public string Title { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverMail { get; set; }
        public string Content { get; set; }
        public string SenderMessage { get; set; }
        public string SenderMail { get; set; }
        public DateTime Date { get; set; }
    }
}

namespace naqulClient.Models
{
    public class NaQulRequestModel
    {
        public NaQulRequestModel(string text)
        {
            nql = text.ToUpper();
        }
         public string nql {get;set;}
    }
}
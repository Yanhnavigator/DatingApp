namespace DatingApp.API.Models
{
    public class User
    {
        //type in prop then tapkey to 
        public int Id {get; set;}

        public string Username {get; set;}
        public byte[] PasswordHash { get; set; }    

        public byte[] PasswordSalt { get; set; }    
            
    
    }
}
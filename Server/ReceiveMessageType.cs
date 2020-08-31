using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [Serializable] 
    public enum MessageType{
            Login,
            CreateUser,
            GetTest,
            UploadTest,
            GetResult
        }
    [Serializable]
    public class ReceiveMessageType
    {
        public MessageType messageType { get; set; }

        public object Data { get; set; }
    }
    [Serializable]
    public class Student
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Second_Name { get; set; }

       
    }
    [Serializable]
    public class Logins
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
    [Serializable]
    public class Teacher
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Second_Name { get; set; }

    }
    [Serializable]
    public class Test
    {
        public int Id { get; set; }
        public 
    }
    [Serializable]
    public class Result
    {

    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ToMakeConnection
{

    [Serializable]
    public enum MessageType : ushort
    {
        Login,
        CreateUser,
        GetTest,
        UploadTest,
        GetResult,
        Error,
        GetStudent,
        GetTeacher

    }
    [Serializable]
    public class ReceiveMessageType
    {
        public MessageType MessageType { get; set; }

        public object Data { get; set; }
    }
    [Serializable]
    public class Student
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Second_Name { get; set; }
        public int Group_Id { get; set; }


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
        public int Test_Id { get; set; }

    }
    [Serializable]
    public class Get_Test
    {
        public int Id { get; set; }

        public XmlReader xml { get; set; }

        //public 
    }
    [Serializable]
    public class Result
    {
        public int Student_id { get; set; }
        public float Test_Result { get; set; }
    }
    [Serializable]
    public class Error
    {
        public string Text_Eror { get; set; }
    }
    [Serializable]
    public class Up_Test
    {
        public string xml { get; set; }
    }
    [Serializable]
    public class Add_User
    {
        public bool isTeacher { get; set; }
        public Logins login { get; set; }
        public Teacher teacher_info { get; set; }
        public Student student_info { get; set; }
    }
}
    



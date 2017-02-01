using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StudentInfo
{
            [ServiceContract]
            public interface IStudent
            {
                [OperationContract]
                [WebInvoke(UriTemplate = "/GetData", Method ="POST" ,BodyStyle = WebMessageBodyStyle.Bare ,RequestFormat =WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
                List <Student1> GetStudent();

                [OperationContract]
                [WebInvoke(UriTemplate = "/GetData/{id}", Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
                List<Student1> GetStudentById(string id);

                [OperationContract]
                [WebInvoke(UriTemplate = "/GetData1/", Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
                List<Student1> GetStudentByObject(Filters jsonObject);
            }

        
}


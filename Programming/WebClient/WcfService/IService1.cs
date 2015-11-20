using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.Model;

namespace WcfService
{
   
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        Person Login(string User, string Password);

        [OperationContract]
        int SubmitHomework(int childId, int assignmentId, DateTime date, string diskName);

        [OperationContract]
        List<Homework> getAllHomeworks();
     
    }


    
}

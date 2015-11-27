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
        Object Login(string User, string Password);

        [OperationContract]
        int SubmitHomework(int childId, int assignmentId, DateTime date, string diskName);

        [OperationContract]
        int CreateAssignment(int teacherId, string subject, string title, string exercise, DateTime date, DateTime deadline);

        [OperationContract]
        ListForObjects GetAllHomeworksById(int assignmentId);

        [OperationContract]
        List<Homework> GetAllHomeworksByChildId(int childId);

        [OperationContract]
        ListForObjects GetAllAssignmentsForTeacherById(int teacherId);
        
        [OperationContract]
        List<Assignment> GetAllAssignments();

        [OperationContract]
        Homework GetHomeworkById(int id);

        [OperationContract]
        int CreateTutoringTime(DateTime date, bool availability, int teacherId, string time);
    }


    
}

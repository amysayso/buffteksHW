using System; 

namespace buffteksHW.Models 
{
	public class Organization 
	{

 	        //PK
            public int OrganizationtID {get; set;}

            //Org Advisor 
            public string OrgAdvisor {get; set;}

            //phone
            public string PhoneNumber {get; set;}

            //email
            public string OrgEmail { get; set; }

             public override string ToString()
        {
            return this.OrgAdvisor + "=" + this.OrgEmail;
        }
        }
}
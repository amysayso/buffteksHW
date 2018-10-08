using System;
using System.Collections.Generic;
using System.Linq;
using buffteksHW.Models;

namespace buffteksHW
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try
                {

                    //no matter what, delete and then create
                    //db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    if(!db.Students.Any())
                    {
                        //STUDENTS 
                        List<Student> students = new List<Student>()
                        {
                            new Student()
                            {
                                FirstName = "Amy",
                                LastName = "Sayso",
                                PhoneNumber = "123-555-1234",
                                Email = "amysay@asdas.com",
                                Role = "Member"
                            },
                            new Student()
                            {
                                FirstName = "Ann",
                                LastName = "Smith",
                                PhoneNumber = "123-124-6684",
                                Email = "fdufaen@asdfa.com",
                                Role = "Member"
                            },
                            new Student()
                            {
                                FirstName = "John",
                                LastName = "Doe",
                                PhoneNumber = "333-555-8888",
                                Email = "sdfasga@dfgafg.dgf",
                                Role = "Member"
                            },                        
                        };

                        db.Students.AddRange(students);
                        db.SaveChanges();
                        Console.WriteLine("Student Added");                                            

                    }
                    else
                    {
                        var students = db.Students.ToList();
                        foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }
                    }
                //CLIENT
                if(!db.Clients.Any())
                    {
                    List<Client> clients = new List<Client>()
                        {
                            new Client()
                            {
                                P_List = "adfasdf",
                                F_Name = "Client1",
                                L_Name = "Client1",
                                PhoneNumber = "124-141-1434",
                                Client_Email = "asfads@fdg",
                                Org = "dsfsfg"
                            },

                             new Client()
                            {
                                P_List = "kjkfkftu",
                                F_Name = "Client2",
                                L_Name = "Client2",
                                PhoneNumber = "777-155-1457",
                                Client_Email = "gsh@hshs.ege",
                                Org = "dfhsdhh"
                            },

                             new Client()
                            {
                                P_List = "hsgdhsgds",
                                F_Name = "Client3",
                                L_Name = "Client3",
                                PhoneNumber = "333-999-0000",
                                Client_Email = "sghsgjgs@hgd",
                                Org = "dsghsg"
                            }
                        };            
                        

                        db.Clients.AddRange(clients);
                        db.SaveChanges();   
                        Console.WriteLine("Clients Added");
                }                                         
            
                    else
                    {
                        var clients = db.Clients.ToList();
                        foreach(Client c in clients)
                        {
                            Console.WriteLine(c);
                        }
                    }

                //ADVISOR
                 if(!db.Advisors.Any())
                    {
                    List<Advisor> advisors = new List<Advisor>()
                        {
                            new Advisor()
                            {
                                Advisor_FName = "Adam",
                                Advisor_LName = "Smith",
                                PhoneNumber = "888-888-8889",
                                Email = "adgagafga@dfg.asd"
                            },

                            new Advisor()
                            {
                                Advisor_FName = "Jackie",
                                Advisor_LName = "Smith",
                                PhoneNumber = "808-511-3449",
                                Email = "aygjfya@dfg.asd"
                            },

                             new Advisor()
                            {
                                Advisor_FName = "Katie",
                                Advisor_LName = "Smith",
                                PhoneNumber = "818-222-3543",
                                Email = "aufhasgha@dfg.asd"
                            }
                        };            
                        

                        db.Advisors.AddRange(advisors);
                        db.SaveChanges();   
                        Console.WriteLine("Advisor Added");
                }                                         
            
                    else
                    {
                        var advisors = db.Advisors.ToList();
                        foreach(Advisor a in advisors)
                        {
                            Console.WriteLine(a);
                        }
                    }

                //TEAM
                 if(!db.Teams.Any())
                    {
                    List<Team> teams = new List<Team>()
                        {
                            new Team()
                            {
                                TeamID = 1,
                                TeamName = "Group1",
                                ProjectName = "Design"
                                
                            },
                            new Team()
                            {
                                TeamID = 2,
                                TeamName = "Group2",
                                ProjectName = "Update"
                                
                            },
                            new Team()
                            {
                                TeamID = 3,
                                TeamName = "Group3",
                                ProjectName = "Content"
                                
                            }
                        };            
                        

                        db.Teams.AddRange(teams);
                        db.SaveChanges();   
                        Console.WriteLine("Teams Added");
                }                                         
            
                    else
                    {
                        var teams = db.Teams.ToList();
                        foreach(Team t in teams)
                        {
                            Console.WriteLine(t);
                        }
                    }

                //PROJECTS
                 if(!db.Projects.Any())
                    {
                    List<Project> projects = new List<Project>()
                        {
                            new Project()
                            {
                                ProjectID = 1,
                                ProjectName = "Project1",
                                ProjectLeader = "Leader1",
                                RequiredHours = "5 hours",
                                Deadline = "Month"
                            },

                             new Project()
                            {
                                ProjectID = 2,
                                ProjectName = "Project2",
                                ProjectLeader = "Leader2",
                                RequiredHours = "10 hours",
                                Deadline = " 3 Month"
                            },

                            new Project()
                            {
                                ProjectID = 3,
                                ProjectName = "Project3",
                                ProjectLeader = "Leader3",
                                RequiredHours = "25 hours",
                                Deadline = " 5 Month"
                            },
                        };            
                        

                        db.Projects.AddRange(projects);
                        db.SaveChanges();   
                        Console.WriteLine("Project Added");
                }                                         
            
                    else
                    {
                        var projects = db.Projects.ToList();
                        foreach(Project p in projects)
                        {
                            Console.WriteLine(p);
                        }
                    }

                    //ORGANIZATION 
                     if(!db.Organizations.Any())
                    {
                    List<Organization> organizations = new List<Organization>()
                        {
                            new Organization()
                            {
                               
                               OrgAdvisor = "John Doe",
                               OrgEmail = "haghoafhgaf@jff.fga"
                            },

                              new Organization()
                            {
                              
                               OrgAdvisor = "Alexis Jones",
                               OrgEmail = "afgafdga@gsfga.fga"
                            },
                             new Organization()
                            {
                               
                               OrgAdvisor = "Rebecca Smith",
                               OrgEmail = "afasgafafganj@ghgg.fga"
                            },
                        };            
                        

                        db.Organizations.AddRange(organizations);
                        db.SaveChanges();   
                        Console.WriteLine("Organization Added");
                }                                         
            
                    else
                    {
                        var organizations = db.Organizations.ToList();
                        foreach(Organization o in organizations)
                        {
                            Console.WriteLine(o);
                        }
                    }
            }
        
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
    }
}
    




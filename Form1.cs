using SchoolManagementDBMS.Data;
using SchoolManagementDBMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace SchoolManagementDBMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            SetupData();
        }

        BackgroundWorker bw;
        private void SetupData()
        {
            lblProcessing.Text = "Setting up data please wait...";

            bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;

            bw.RunWorkerAsync();
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (var ctx = new SchoolContext())
                {
                    if (!ctx.Teachers.Any())
                    {
                        var teacher = new List<Teacher>()
                        {
                            new Teacher()
                            {
                                Name = "Shankar",
                                Subjects = new List<Subject>()
                                {
                                    new Subject() { Name = "English"},
                                    new Subject() { Name = "Social"}
                                },
                                TableNumber = 101
                            },

                            new Teacher()
                            {
                                Name = "Sachin",
                                Subjects = new List<Subject>()
                                {
                                    new Subject() { Name = "Physics"},
                                },
                                TableNumber = 102
                    }
                        };
                        ctx.Teachers.AddRange(teacher);
                    }
                    
                    ctx.SaveChanges();
                    e.Result = "Ready!";
                }
            }
            catch (Exception ex)
            {
                e.Result = ex.Message;
            }
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblProcessing.Text = e.Result.ToString();
        }

        private void btnShowTeacher_Click(object sender, EventArgs e)
        {
            using (var ctx = new SchoolContext())
            {
                var typename = ctx.Subjects.FirstOrDefault()?.Teacher.Name?? "NA";
                MessageBox.Show(typename);
            }
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new SchoolContext())
                {
                    if (!ctx.Standards.Any())
                    {
                        var classes = new List<Standard>()
                        {
                            new Standard()
                            {
                                StandardName = "Sixth",
                                Students = new List<Student>()
                                {
                                    new Student(){Name = "Praveen"}
                                }

                            },
                            new Standard()
                            {
                                StandardName = "Eigth",
                                Students = new List<Student>()
                                {
                                    new Student(){Name = "Puneeth"}
                                }
                            }
                        };
                        ctx.Standards.AddRange(classes);
                    }
                    ctx.SaveChanges();
                    MessageBox.Show("Added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }      
        }

        private void btnCreateTeacher_Click(object sender, EventArgs e)
        {
            using (var ctx = new SchoolContext())
            {
                try
                {
                    var teacher = new Teacher()
                    {
                        Name = "Francis",
                        Subjects = new List<Subject>()
                        {
                            new Subject() { Name = "Scinece" },
                            new Subject() { Name = "environmental studies" }
                        },
                        TableNumber = 103
                    };

                    ctx.Teachers.Add(teacher);
                    ctx.SaveChanges();
                    MessageBox.Show("Added");
                }
                catch
                {
                    MessageBox.Show("Already Created");
                }
            }
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new SchoolContext())
                {
                    var teacher = ctx.Teachers.SqlQuery("Select * from Teachers where TableNumber = 103");
                    var name = teacher.FirstOrDefault()?.Name ?? "NA";
                    if (name != "NA")
                    {
                        MessageBox.Show($"{name} is Deleted");
                    }                    

                    ctx.Teachers.Remove(ctx.Teachers.Single(a => a.TableNumber == 103));
                    ctx.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("Already Deleted");
            }
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new SchoolContext())
                {
                    var examNames = new List<ExamName>()
                    {
                        new ExamName()
                        {
                            Name = "FirstIA",
                            TotalMarks = 25,
                            Exams = new List<Exam>()
                            {
                                new Exam()
                                {
                                    Date = DateTime.Parse("10/1/2019 11:00:00 AM"),
                                    SubjectAverage = 19.766,
                                    SubjectName = "English"
                                },
                                new Exam() 
                                { 
                                    Date = DateTime.Parse("11/1/2019 11:00:00 AM"),
                                    SubjectAverage = 21.911,
                                    SubjectName = "Physics"
                                },
                                new Exam() 
                                { 
                                    Date = DateTime.Parse("12/1/2019 11:00:00 AM"),
                                    SubjectAverage = 18.66,
                                    SubjectName = "Social"
                                }
                            }
                        },
                        new ExamName(){
                            Name = "SecondIA",
                            TotalMarks = 25,
                            Exams = new List<Exam>()
                            {
                               new Exam()
                                {
                                    Date = DateTime.Parse("10/2/2019 11:00:00 AM"),
                                    SubjectAverage = 20.596,
                                    SubjectName = "English"
                                },
                                new Exam()
                                {
                                    Date = DateTime.Parse("11/2/2019 11:00:00 AM"),
                                    SubjectAverage = 23.548,
                                    SubjectName = "Physics"
                                },
                                new Exam()
                                {
                                    Date = DateTime.Parse("12/2/2019 11:00:00 AM"),
                                    SubjectAverage = 16.235,
                                    SubjectName = "Social"
                                }
                            }
},
                        new ExamName()
                        {
                            Name = "ThirdIA",
                            TotalMarks = 25,
                            Exams = new List<Exam>()
                            {
                                new Exam()
                                {
                                    Date = DateTime.Parse("10/3/2019 11:00:00 AM"),
                                    SubjectAverage = 22.254,
                                    SubjectName = "English"
                                },
                                new Exam()
                                {
                                    Date = DateTime.Parse("11/3/2019 11:00:00 AM"),
                                    SubjectAverage = 23.265,
                                    SubjectName = "Physics"
                                },
                                new Exam()
                                {
                                    Date = DateTime.Parse("12/3/2019 11:00:00 AM"),
                                    SubjectAverage = 19.356,
                                    SubjectName = "Social"
                                }
                            }
                        },
                        new ExamName()
                        {
                            Name = "SEE",
                            TotalMarks = 100,
                            Exams = new List<Exam>()
                            {
                                new Exam()
                                {
                                    Date = DateTime.Parse("20/4/2019 11:00:00 AM"),
                                    SubjectAverage = 82.235,
                                    SubjectName = "English"
                                },
                                new Exam()
                                {
                                    Date = DateTime.Parse("21/4/2019 11:00:00 AM"),
                                    SubjectAverage = 95.623,
                                    SubjectName = "Physics"
                                },
                                new Exam()
                                {
                                    Date = DateTime.Parse("22/4/2019 11:00:00 AM"),
                                    SubjectAverage = 78.856,
                                    SubjectName = "Social"
                                }
                            }
                        }
                    };
                    ctx.ExamNames.AddRange(examNames);
                    ctx.SaveChanges();
                    MessageBox.Show("Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new SchoolContext())
                {
                    var temp = textBox1.Text;
                    var SubjectName = ctx.Exams.Where(p => p.SubjectName.Contains(temp));
                    double TotalAverage = 0;
                    if (SubjectName.Any())
                    {
                        TotalAverage = SubjectName.Sum(k => k.SubjectAverage/1.75);
                    }
                    MessageBox.Show($"{temp} annual Average is {TotalAverage}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

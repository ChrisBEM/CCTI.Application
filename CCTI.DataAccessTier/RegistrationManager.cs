using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using BusinessEntities;

namespace CCTI.DataAccessTier
{
    public class RegistrationManager
    {
        private static RegistrationManager _manager =
      new RegistrationManager();

        //declare data objects
        private DataSet _db;
        private SqlDataAdapter _studentAdapter;
        private SqlDataAdapter _classRosterAdapter;
        private SqlDataAdapter _courseSectionAdapter;
        private SqlDataAdapter _courseAdapter;
        private SqlDataAdapter _provinceAdapter;
        private SqlDataAdapter _departmentAdapter;

        private RegistrationManager()
        {
            //get connection string
            string connString =
              ConfigurationManager.ConnectionStrings["RegistrationConnection"].ConnectionString;
            //instantiate the data objects
            _db = new DataSet("Registration");

            //instantiate the student data adapter
            _studentAdapter = new SqlDataAdapter("SELECT * FROM Student", connString);
            SqlCommandBuilder cb = new SqlCommandBuilder(_studentAdapter);
            _studentAdapter.InsertCommand = cb.GetInsertCommand();
            _studentAdapter.UpdateCommand = cb.GetUpdateCommand();
            _studentAdapter.DeleteCommand = cb.GetDeleteCommand();
            _studentAdapter.FillSchema(_db, SchemaType.Source, "Student");
            _studentAdapter.Fill(_db, "Student");

            //instantiate the course data adapter
            _courseAdapter = new SqlDataAdapter("SELECT * FROM Course", connString);
            cb = new SqlCommandBuilder(_courseAdapter);
            _courseAdapter.InsertCommand = cb.GetInsertCommand();
            _courseAdapter.UpdateCommand = cb.GetUpdateCommand();
            _courseAdapter.DeleteCommand = cb.GetDeleteCommand();
            _courseAdapter.FillSchema(_db, SchemaType.Source, "Course");
            _courseAdapter.Fill(_db, "Course");

            //instantiate the courseSection data adapter
            _courseSectionAdapter = new SqlDataAdapter("SELECT * FROM CourseSection", connString);
            cb = new SqlCommandBuilder(_courseSectionAdapter);
            _courseSectionAdapter.InsertCommand = cb.GetInsertCommand();
            _courseSectionAdapter.UpdateCommand = cb.GetUpdateCommand();
            _courseSectionAdapter.DeleteCommand = cb.GetDeleteCommand();
            _courseSectionAdapter.FillSchema(_db, SchemaType.Source, "CourseSection");
            _courseSectionAdapter.Fill(_db, "CourseSection");

            //instantiate the classRoster data adapter
            _classRosterAdapter = new SqlDataAdapter("SELECT * FROM ClassRoster", connString);
            cb = new SqlCommandBuilder(_classRosterAdapter);
            _classRosterAdapter.InsertCommand = cb.GetInsertCommand();
            _classRosterAdapter.UpdateCommand = cb.GetUpdateCommand();
            _classRosterAdapter.DeleteCommand = cb.GetDeleteCommand();
            _classRosterAdapter.FillSchema(_db, SchemaType.Source, "ClassRoster");
            _classRosterAdapter.Fill(_db, "ClassRoster");

            //instantiate the province data adapter
            _provinceAdapter = new SqlDataAdapter("SELECT * FROM Province", connString);
            cb = new SqlCommandBuilder(_provinceAdapter);
            _provinceAdapter.InsertCommand = cb.GetInsertCommand();
            _provinceAdapter.UpdateCommand = cb.GetUpdateCommand();
            _provinceAdapter.DeleteCommand = cb.GetDeleteCommand();
            _provinceAdapter.FillSchema(_db, SchemaType.Source, "Province");
            _provinceAdapter.Fill(_db, "Province");

            //instantiate the department data adapter
            _departmentAdapter = new SqlDataAdapter("SELECT * FROM Department", connString);
            cb = new SqlCommandBuilder(_departmentAdapter);
            _departmentAdapter.InsertCommand = cb.GetInsertCommand();
            _departmentAdapter.UpdateCommand = cb.GetUpdateCommand();
            _departmentAdapter.DeleteCommand = cb.GetDeleteCommand();
            _departmentAdapter.FillSchema(_db, SchemaType.Source, "Department");
            _departmentAdapter.Fill(_db, "Department");

            //create the datarelation
            DataRelation dr =
              new DataRelation("FK_Student_ClassRoster",
                               _db.Tables["Student"].Columns["ID"],
                               _db.Tables["ClassRoster"].Columns["StudentID"]);
            _db.Relations.Add(dr);

            DataRelation dr1 =
              new DataRelation("FK_Course_ClassRoster",
                               _db.Tables["Course"].Columns["Code"],
                               _db.Tables["ClassRoster"].Columns["CourseCode"]);
            _db.Relations.Add(dr1);

            DataRelation dr2 =
              new DataRelation("FK_CourseSection_ClassRoster",
                               _db.Tables["CourseSection"].Columns["SectionCode"],
                               _db.Tables["ClassRoster"].Columns["SectionCode"]);
            _db.Relations.Add(dr2);

            DataRelation dr3 =
              new DataRelation("FK_Course_CourseSection",
                               _db.Tables["Course"].Columns["Code"],
                               _db.Tables["CourseSection"].Columns["CourseCode"]);
            _db.Relations.Add(dr3);

            DataRelation dr4 =
             new DataRelation("FK_Department_Course",
                              _db.Tables["Department"].Columns["ID"],
                              _db.Tables["Course"].Columns["DepartmentID"]);
            _db.Relations.Add(dr4);
        }

        public static RegistrationManager Instance
        {
            get { return _manager; }
        }

        /// <summary>
        /// Get all students
        /// </summary>
        /// <returns></returns>
        public IList<Student> GetStudents()
        {

            List<Department> departments = GetDepartments().ToList();

            List<Student> students =  _db.Tables["Student"].ToList<Student>();

            // Assign the department for each student. 
            foreach (Student student in students)
            {
                student.Department = departments.Find(x => x.ID == student.DepartmentID);
            }

            return students;
        }

        public List<Course> GetStudentCourses(Student student)
        {
            return GetCourses(student.DepartmentID);
        } 

        /// <summary>
        /// Get the list of courses
        /// </summary>
        /// <returns></returns>
        public List<Course> GetCourses()
        {
            List<Department> departments = GetDepartments();

            List<Course> courses = _db.Tables["Course"].ToList<Course>();

            // Assign the department for each course. 
            foreach (Course course in courses)
            {
                course.Department = departments.Find(x => x.ID == course.DepartmentID);
            }

            return courses;
        }


        public List<Student> GetStudentByCourses(Course course)
        {
            return GetStudents(course.DepartmentID);
        }
        /// <summary>
        /// Get the list of courses
        /// </summary>
        /// <returns></returns>
        public List<Course> GetCourses(int departmentID)
        {
            List<Department> departments = GetDepartments();

            List<Course> courses = _db.Tables["Course"].ToList<Course>();

            // Assign the department for each course. 
            foreach (Course course in courses)
            {
                course.Department = departments.Find(x => x.ID == course.DepartmentID);
            }

            return courses.FindAll(x => x.DepartmentID == departmentID);
        }

        public List<Student> GetStudents(int departmentID)
        {

            List<Department> departments = GetDepartments();

            List<Student> students = _db.Tables["Student"].ToList<Student>();

            // Assign the department for each student. 
            foreach (Student student in students)
            {
                student.Department = departments.Find(x => x.ID == student.DepartmentID);
            }

            return students.FindAll(x => x.DepartmentID == departmentID);
        }

        /// <summary>
        /// Get the list of courses Section
        /// </summary>
        /// <returns></returns>
        public List<CourseSection> GetCourseSection(string courseCode)
        {
            List<Course> courses = GetCourses();

            List<CourseSection> courseSections = _db.Tables["CourseSection"].ToList<CourseSection>();

            // Assign the course for each  Section. 
            foreach (CourseSection courseSection in courseSections)
            {
                courseSection.Course  = courses.Find(x => x.Code  == courseSection.CourseCode);
            }

            return courseSections.FindAll(x => x.CourseCode == courseCode);
        }


        /// <summary>
        /// Get the list of class rosters
        /// </summary>
        /// <returns></returns>
        public List<ClassRoster> GetClassRoster()
        {
            List<Course> courses = GetCourses();

            List<CourseSection> courseSections = GetCourseSection();

            List<ClassRoster> classRosters = _db.Tables["ClassRoster"].ToList<ClassRoster>();

            foreach (ClassRoster roster in classRosters)
            {
                roster.Course = courses.Find(x => x.Code == roster.CourseCode);
                roster.CourseSection = courseSections.Find(x => x.SectionCode == roster.SectionCode);
            }

            return classRosters;
        }

        /// <summary>
        /// Get the list of course sections
        /// </summary>
        /// <returns></returns>
        public List<CourseSection> GetCourseSection()
        {

            List<Course> courses = GetCourses();

            List<CourseSection> courseSections = _db.Tables["CourseSection"].ToList<CourseSection>();

            foreach (CourseSection courseSection in courseSections)
            {
                courseSection.Course = courses.Find(x => x.Code == courseSection.CourseCode);
            }

            return courseSections;
        }

        /// <summary>
        /// Get list of provinces
        /// </summary>
        /// <returns></returns>
        public List<Province> GetProvinces()
        {
            return _db.Tables["Province"].ToList<Province>();
        }

        /// <summary>
        /// Get list of departments
        /// </summary>
        /// <returns></returns>
        public List<Department> GetDepartments()
        {
            return _db.Tables["Department"].ToList<Department>();
        }

        public void AddStudent(string studentFName, string studentLName,
                               string studentAddress, string studentCity, string studentProvince, 
                               string studentPostalcode, string studentPhone, string studentEmail, int studentDpt)
        {
            var row = _db.Tables["Student"].NewRow();
            row["FirstName"] = studentFName;
            row["LastName"] = studentLName;
            row["Address"] = studentAddress;
            row["City"] = studentCity;
            row["Province"] = studentProvince;
            row["PostalCode"] = studentPostalcode;
            row["Phone"] = studentPhone;
            row["DepartmentID"] = studentDpt;
            _db.Tables["Student"].Rows.Add(row);
        }

        public void AddCourse(string code, string name, string description, decimal cost,
                               int departmentID)
        {
            var row = _db.Tables["Course"].NewRow();
            row["Code"] = code;
            row["Name"] = name;
            row["Description"] = description;
            row["Cost"] = cost;
            row["DepartmentID"] = departmentID;
            _db.Tables["Course"].Rows.Add(row);
        }

        public void AddClassRoster(string courseCode, string sectionCode,
                              int studentID, DateTime dateRegistered)
        {
            var row = _db.Tables["ClassRoster"].NewRow();
            row["CourseCode"] = courseCode;
            row["SectionCode"] = sectionCode;
            row["StudentID"] = studentID;
            row["DateRegistered"] = dateRegistered;
            _db.Tables["ClassRoster"].Rows.Add(row);
        }

        public void AddCourseSection(string courseCode, string sectionCode,
                              DateTime startDate, DateTime endDate, string roomNumber)
        {
            var row = _db.Tables["CourseSection"].NewRow();
            row["CourseCode"] = courseCode;
            row["SectionCode"] = sectionCode;
            row["StartDate"] = startDate;
            row["EndDate"] = endDate;
            row["RoomNumber"] = roomNumber;
            _db.Tables["CourseSection"].Rows.Add(row);
        }

        public void SaveAll()
        {
            //persist the changes made to the tables
            DataSet newDS = _db.GetChanges();
            if (newDS == null) { return; } //return if no changes

            _studentAdapter.Update(newDS, Constants.TablesNames.Student);
            _courseAdapter.Update(newDS, Constants.TablesNames.Course);
            _courseSectionAdapter.Update(newDS, Constants.TablesNames.CourseSection);
            _classRosterAdapter.Update(newDS, Constants.TablesNames.ClassRoster);
            _departmentAdapter.Update(newDS, Constants.TablesNames.Department);


            _db.AcceptChanges();
        }
    }
}

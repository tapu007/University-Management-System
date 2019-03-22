using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.Models.EntityModels;
using UniversityApp.Models;

namespace UniversityApp.AutoMapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<CourseViewModle, Course>();
            CreateMap<Course, CourseViewModle>();

            CreateMap<CourseAssignToTeacherViewModel, CourseAssignToTeacher>();
            CreateMap<CourseAssignToTeacher, CourseAssignToTeacherViewModel>();

            CreateMap<DepartmentViewModel, Department>();
            CreateMap<Department, DepartmentViewModel>();

            CreateMap<TeacherViewModel, Teacher>();
            CreateMap<Teacher, TeacherViewModel>();

            CreateMap<Student, StudentViewModel>();
            CreateMap<StudentViewModel, Student>();

            CreateMap<CourseEnrollToStudentViewModel, CourseEnrollToStudent>();
            CreateMap<CourseEnrollToStudent, CourseEnrollToStudentViewModel>();

            CreateMap<DesignationViewModel, Designation>();
            CreateMap<Designation, DesignationViewModel>();

            CreateMap<AllocateClassRoomViewModel, AllocateClassRoom>();
            CreateMap<AllocateClassRoom, AllocateClassRoomViewModel>();

            CreateMap<StudentResultViewModel, StudentResult>();
            CreateMap<StudentResult, StudentResultViewModel>();
        }
    }
}

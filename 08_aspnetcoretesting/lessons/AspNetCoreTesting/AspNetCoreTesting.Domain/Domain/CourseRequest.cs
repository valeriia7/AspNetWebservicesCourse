﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTesting.Domain.Domain
{
    public class CourseRequest
    {
        public string StudentId { get; private set; }
        public Student Student { get; private set; }
        public string RequestedCourseId { get; private set; }
        public Course RequestedCourse { get; private set; }

        private CourseRequest()
        {
        }
    }
}

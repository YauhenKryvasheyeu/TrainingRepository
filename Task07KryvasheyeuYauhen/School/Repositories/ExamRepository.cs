﻿using School.Models;
using System.Data.Linq;

namespace School.Repositories
{
    /// <summary>
    /// describes the interaction with the exams table
    /// </summary>
    public class ExamRepository : Repository<Exam>
    {
        public ExamRepository(DataContext dataContext) : base(dataContext)
        { }

        /// <summary>
        /// updates an exam in the exams table
        /// </summary>
        /// <param name="exam"></param>
        public override void Update(Exam exam)
        {
            var newExam = GetById(exam.Id);
            newExam.SubjectId = exam.SubjectId;
            newExam.SessionId = exam.SessionId;
            newExam.Date = exam.Date;
            newExam.TeacherId = exam.TeacherId;
            _dataContext.SubmitChanges();
        }
    }
}

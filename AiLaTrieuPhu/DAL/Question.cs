﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiLaTrieuPhu.DAL
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public string TrueAnswer { get; set; }
        public int Level { get; set; }
    }
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public long WInMoney { get; set; }
    }
}

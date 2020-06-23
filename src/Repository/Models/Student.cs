﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.Models
{
  public class Student: IEntity
  {
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string Year { get; set; }
  }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Angular17WithASP.Core.Entities;

public partial class Task
{
    public int Id { get; set; }

    public int ContactId { get; set; }

    public string Text { get; set; }

    public DateTime Date { get; set; }

    public string Status { get; set; }

    public string Priority { get; set; }

    public virtual Contact Contact { get; set; }
}
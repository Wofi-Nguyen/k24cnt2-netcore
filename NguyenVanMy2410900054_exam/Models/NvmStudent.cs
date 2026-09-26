using System;
using System.Collections.Generic;

namespace NguyenVanMy2410900054_exam.Models;

public partial class NvmStudent
{
    public long? Id { get; set; }

    public string? NvmName { get; set; }

    public bool? NvmGender { get; set; }

    public DateOnly? NvmBirthday { get; set; }

    public string? NvmEmail { get; set; }

    public string? NvmPhone { get; set; }

    public bool? NvmActive { get; set; }
}

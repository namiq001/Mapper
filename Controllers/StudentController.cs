using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.DTOs.StudentDto;
using Project.Entities;

namespace Project.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{
    private readonly IMapper _mapper;

    public StudentController(IMapper mapper)
    {
        _mapper = mapper;
    }

    [HttpPost]
    public string Create(CreateStudentDto createStudent)
    {
        Student student = _mapper.Map<Student>(createStudent);

        return $"{student.FullName}";
    }
}

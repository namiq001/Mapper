using AutoMapper;
using Project.DTOs.StudentDto;
using Project.Entities;

namespace Project;

public class MapperProfile : Profile
{
	public MapperProfile()
	{
		CreateMap<CreateStudentDto, Student>()
			.ForMember(destination => destination.FullName, operation => operation.MapFrom(source => source.Name + " " + source.Surname));
	}
}

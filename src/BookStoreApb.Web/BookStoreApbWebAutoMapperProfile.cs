using AutoMapper;
using BookStoreApb.BookDtos;

namespace BookStoreApb.Web;

public class BookStoreApbWebAutoMapperProfile : Profile
{
    public BookStoreApbWebAutoMapperProfile()
    {
        //Define your object mappings here, for the Web project
        CreateMap<BookDto, CreateUpdateBookDto>();
    }
}

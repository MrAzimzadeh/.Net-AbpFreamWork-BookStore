using AutoMapper;
using BookStoreApb.AuthorDtos;
using BookStoreApb.Authors;
using BookStoreApb.BookDtos;
using BookStoreApb.Books;

namespace BookStoreApb;

public class BookStoreApbApplicationAutoMapperProfile : Profile
{
    public BookStoreApbApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<Author, AuthorDto>();
        CreateMap<Author, AuthorLookupDto>();



    }
}

using LibraryAPI.Models.Requests;
using LibraryAPI.Models.Responses;

namespace LibraryAPI.Services;

public interface IBookService
{
    Task Rent(RentBookRequest request);
    Task<GetBookByParamsResponse> GetBooksByParams(GetBooksByParamsRequest request);
}
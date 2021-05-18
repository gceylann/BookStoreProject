using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpPost("add")]
        public IActionResult Add(Book book)
        {
            var result = _bookService.Add(book);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("delete")]
        public IActionResult Delete(Book book)
        {
            var result = _bookService.Delete(book);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("update")]
        public IActionResult Update(Book book)
        {
            var result = _bookService.Update(book);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _bookService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("getbyid")]
        public IActionResult Get(int bookId)
        {
            var result = _bookService.GetById(bookId);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("getbookdetails")]
        public IActionResult GetBookDetails(int bookId)
        {
            var result = _bookService.GetBookDetails(bookId);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("getbooksbycategory")]
        public IActionResult GetBooksByCategory(int categoryId)
        {
            var result = _bookService.GetBooksByCategory(categoryId);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("getbooksbyauthor")]
        public IActionResult GetBooksByAuthor(int authorId)
        {
            var result = _bookService.GetBooksByAuthor(authorId);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }


        [HttpGet("getbooksbypublisher")]
        public IActionResult GetBooksByPublisher(int publisherId)
        {
            var result = _bookService.GetBooksByPublisher(publisherId);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("getbooksbyfilter")]
        public IActionResult GetBookDetailsByFilter(int authorId, int publisherId)
        {
            var result = _bookService.GetBooksByFilter(authorId, publisherId);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}

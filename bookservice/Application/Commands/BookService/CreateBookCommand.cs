using MediatR;

namespace Application.Commands.BookService
{
    public class CreateBookCommand : IRequest<int>
    {
        public int Id  { get; set; }
    
        
        public string Description { get; set; }
        
    
        
        public string ISBN { get; set; }
        
    
        
        public string Language { get; set; }
        
    
        
        public int PageCount { get; set; }
        
    
        
        public string PublishDate { get; set; }
        
    
        
        public string Title { get; set; }
        
    
    }
}

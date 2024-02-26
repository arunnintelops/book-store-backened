using Core.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Book : EntityBase
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

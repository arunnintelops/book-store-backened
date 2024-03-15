using Core.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class User : EntityBase
    {
        public int Id  { get; set; }
    
        
        public string Address { get; set; }
        
    
        
        public int Age { get; set; }
        
    
        
        public string Email { get; set; }
        
    
        
        public string Name { get; set; }
        
    
        
        public string Phone { get; set; }
        
    
    }
}

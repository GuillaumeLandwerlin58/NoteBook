using Logic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestLogic
{
    public class UnitTest1
    {
        [Fact]
    public void testEducationalElement()
    {
        EducationalElement ed = new EducationalElement();
        Assert.Throws<Exception>(() => { ed.Coef = -1; });
        Assert.Throws<Exception>(() => { ed.Name = ""; });
        ed.Coef = 6;
        ed.Name = "test";
        Assert.Equal(6, ed.Coef);
        Assert.Equal("test", ed.Name);
    }
    }
}
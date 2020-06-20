using NUnit.Framework;
using MessageAliens;

namespace Tests
{
    public class MessageAliensTest
    {
        [Test]
        public void SampleDecode()
        {
            Assert.AreEqual("hello", AlienMessageDecoder.Decode(@"]()]|_]]|_]][-]|-|]"));
            Assert.AreEqual("blip", AlienMessageDecoder.Decode("{|^{|{{|_{]3{"));
            Assert.AreEqual("die stupid people", AlienMessageDecoder.Decode("..[-.|_.|^....().[-.|^.__..|)...|.|^.|_|..~|~._\\~.__...[-..|.|).."));
            Assert.AreEqual("your brain looks delicious", AlienMessageDecoder.Decode("'''_\\~'|_|'()'|''('|'|_'[-'|)''__'_\\~'/<'()'()'|_'''__'|\\|'|''/\\'/?']3'__''/?'|_|''()'`/''"));
            Assert.AreEqual("try to find duplicated kata", AlienMessageDecoder.Decode("}/\\}~|~}/\\}/<}__}|)}}}[-}~|~}/\\}(}|}|_}|^}|_|}|)}__}|)}}}|\\|}|}/=}__}()}}}~|~}__}`/}/?}}~|~}"));
        }
    }
}

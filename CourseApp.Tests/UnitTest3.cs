using System;
using Xunit;
using CourseApp;

namespace CourseApp.tests
{
    public class UnitTest3
    {
        [Fact]
        public void Test12()
        {
            Dog rex = new Dog();
            var Name = rex.Name;
            var Age = rex.Age;
            var Color = rex.Color;
            var Word = Program.Gav( rex );
            Assert.Equal("Rex", rex.Name);
            Assert.Equal(5, rex.Age);
            Assert.Equal("черный", rex.Color);
            Assert.Equal($"пес {Name} сказал \"Гав-Гав!\"", Word);
        }

        [Fact]
        public void test13()
        {
            Dog rex = new Dog();
            string Pes = Program.Pes( rex );
            Assert.Equal(@"                            ..,,,,,,,,,.. 
                     .,;%%%%%%%%%%%%%%%%%%%%;,. 
                   %%%%%%%%%%%%%%%%%%%%////%%%%%%, .,;%%;, 
            .,;%/,%%%%%/////%%%%%%%%%%%%%%////%%%%,%%//%%%, 
        .,;%%%%/,%%%///%%%%%%%%%%%%%%%%%%%%%%%%%%%%,////%%%%;, 
     .,%%%%%%//,%%%%%%%%%%%%%%%%@@%a%%%%%%%%%%%%%%%%,%%/%%%%%%%;, 
   .,%//%%%%//,%%%%///////%%%%%%%@@@%%%%%%///////%%%%,%%//%%%%%%%%, 
 ,%%%%%///%%//,%%//%%%%%///%%%%%@@@%%%%%////%%%%%%%%%,/%%%%%%%%%%%%% 
.%%%%%%%%%////,%%%%%%%//%///%%%%@@@@%%%////%%/////%%%,/;%%%%%%%%/%%% 
%/%%%%%%%/////,%%%%///%%////%%%@@@@@%%%///%%/%%%%%//%,////%%%%//%%%' 
%//%%%%%//////,%/%a`  'a%///%%%@@@@@@%%////a`  'a%%%%,//%///%/%%%%% 
%///%%%%%%///,%%%%@@aa@@%//%%%@@@@S@@@%%///@@aa@@%%%%%,/%////%%%%% 
%%//%%%%%%%//,%%%%%///////%%%@S@@@@SS@@@%%/////%%%%%%%,%////%%%%%' 
%%//%%%%%%%//,%%%%/////%%@%@SS@@@@@@@S@@@@%%%%/////%%%,////%%%%%' 
`%/%%%%//%%//,%%%///%%%%@@@S@@@@@@@@@@@@@@@S%%%%////%%,///%%%%%' 
  %%%%//%%%%/,%%%%%%%%@@@@@@@@@@@@@@@@@@@@@SS@%%%%%%%%,//%%%%%' 
  `%%%//%%%%/,%%%%@%@@@@@@@@@@@@@@@@@@@@@@@@@S@@%%%%%,/////%%' 
   `%%%//%%%/,%%%@@@SS@@SSs@@@@@@@@@@@@@sSS@@@@@@%%%,//%%//%' 
    `%%%%%%/  %%S@@SS@@@@@Ss` .,,.    'sS@@@S@@@@%'  ///%/%' 
      `%%%/    %SS@@@@SSS@@S.         .S@@SSS@@@@'    //%%' 
               /`S@@@@@@SSSSSs,     ,sSSSSS@@@@@' 
             %%//`@@@@@@@@@@@@@Ss,sS@@@@@@@@@@@'/ 
           %%%%@@00`@@@@@@@@@@@@@'@@@@@@@@@@@'//%% 
       %%%%%%a%@@@@000aaaaaaaaa00a00aaaaaaa00%@%%%%% 
    %%%%%%a%%@@@@@@@@@@000000000000000000@@@%@@%%%@%%% 
 %%%%%%a%%@@@%@@@@@@@@@@@00000000000000@@@@@@@@@%@@%%@%% 
%%%aa%@@@@@@@@@@@@@@0000000000000000000000@@@@@@@@%@@@%%%% 
%%@@@@@@@@@@@@@@@00000000000000000000000000000@@@@@@@@@%%%%%", Pes);
        }
    }
}
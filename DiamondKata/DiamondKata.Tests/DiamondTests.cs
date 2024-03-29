/* 
 Dec  Char                           Dec  Char     Dec  Char     Dec  Char
---------                           ---------     ---------     ----------
  0  NUL (null)                      32  SPACE     64  @         96  `
  1  SOH (start of heading)          33  !         65  A         97  a
  2  STX (start of text)             34  "         66  B         98  b
  3  ETX (end of text)               35  #         67  C         99  c
  4  EOT (end of transmission)       36  $         68  D        100  d
  5  ENQ (enquiry)                   37  %         69  E        101  e
  6  ACK (acknowledge)               38  &         70  F        102  f
  7  BEL (bell)                      39  '         71  G        103  g
  8  BS  (backspace)                 40  (         72  H        104  h
  9  TAB (horizontal tab)            41  )         73  I        105  i
 10  LF  (NL line feed, new line)    42  *         74  J        106  j
 11  VT  (vertical tab)              43  +         75  K        107  k
 12  FF  (NP form feed, new page)    44  ,         76  L        108  l
 13  CR  (carriage return)           45  -         77  M        109  m
 14  SO  (shift out)                 46  .         78  N        110  n
 15  SI  (shift in)                  47  /         79  O        111  o
 16  DLE (data link escape)          48  0         80  P        112  p
 17  DC1 (device control 1)          49  1         81  Q        113  q
 18  DC2 (device control 2)          50  2         82  R        114  r
 19  DC3 (device control 3)          51  3         83  S        115  s
 20  DC4 (device control 4)          52  4         84  T        116  t
 21  NAK (negative acknowledge)      53  5         85  U        117  u
 22  SYN (synchronous idle)          54  6         86  V        118  v
 23  ETB (end of trans. block)       55  7         87  W        119  w
 24  CAN (cancel)                    56  8         88  X        120  x
 25  EM  (end of medium)             57  9         89  Y        121  y
 26  SUB (substitute)                58  :         90  Z        122  z
 27  ESC (escape)                    59  ;         91  [        123  {
 28  FS  (file separator)            60  <         92  \        124  |
 29  GS  (group separator)           61  =         93  ]        125  }
 30  RS  (record separator)          62  >         94  ^        126  ~
 31  US  (unit separator)            63  ?         95  _        127  DEL
 */
using Shouldly;
using Xunit;

namespace DiamondKata.Tests
{
    public class DiamondTests
    {
        [Fact]
        public void GenerateSingleLine_ShouldIngnorePaddingMiddleWhenInputIs_A()
        {
            //Arrange 
            const string expectedResult = "   A";

            //Act
            string sut = Diamond.GenerateSingleLine(3, 'A', 3);

            //Assert
            sut.ShouldBe(expectedResult);
        }


        [Fact]
        public void GenerateSingleLine_ShouldSucceddWhenInutIs_B()
        {
            //Arrange 
            const string expectedResult = "  B B";

            //Act
            string sut = Diamond.GenerateSingleLine(2, 'B', 1);

            //Assert
            sut.ShouldBe(expectedResult);
        }

        [Fact]
        public void GenerateSingleLine_ShouldSucceddWhenInutIs_C()
        {
            //Arrange 
            const string expectedResult = " C   C";

            //Act
            string sut = Diamond.GenerateSingleLine(1, 'C', 3);

            //Assert
            sut.ShouldBe(expectedResult);
        }

        [Fact]
        public void GenerateSingleLine_ShouldSucceddWhenInutIs_D()
        {
            //Arrange 
            const string expectedResult = "D     D";

            //Act
            string sut = Diamond.GenerateSingleLine(0, 'D', 5);

            //Assert
            sut.ShouldBe(expectedResult);
        }

        [Fact]
        public void GenerateHalfDiamond_ShouldFailWhenArgumentIsOutOfRange()
        {
            Should.Throw<ArgumentOutOfRangeException>(() => Diamond.GenerateHalfDiamond('!'));
        }

        [Fact]
        public void GenerateHalfDiamond_ShouldSucceddWhenInutIs_A()
        {
            //Arrange 
            const char param = 'A';

            //Act
            List<string> sut = Diamond.GenerateHalfDiamond(param);

            //Assert
            sut.ShouldNotBeNull();
            sut.Count.ShouldBe(1);
            sut.ElementAt(0).ShouldBe(param.ToString());
        }

        [Fact]
        public void GenerateHalfDiamond_ShouldSucceddWhenInutIs_B()
        {
            //Arrange 
            const char param = 'B';

            //Act
            List<string> sut = Diamond.GenerateHalfDiamond(param);

            //Assert
            sut.ShouldNotBeNull();
            sut.Count.ShouldBe(2);
            sut.ElementAt(0).ShouldBe(" A");
            sut.ElementAt(1).ShouldBe("B B");
        }

        [Fact]
        public void GenerateHalfDiamond_ShouldSucceddWhenInutIs_C()
        {
            //Arrange 
            const char param = 'C';

            //Act
            List<string> sut = Diamond.GenerateHalfDiamond(param);

            //Assert
            sut.ShouldNotBeNull();
            sut.Count.ShouldBe(3);
            sut.ElementAt(0).ShouldBe("  A");
            sut.ElementAt(1).ShouldBe(" B B");
            sut.ElementAt(2).ShouldBe("C   C");
        }

        [Fact]
        public void GenerateHalfDiamond_ShouldSucceddWhenInutIs_D()
        {
            //Arrange 
            const char param = 'D';

            //Act
            List<string> sut = Diamond.GenerateHalfDiamond(param);

            //Assert
            sut.ShouldNotBeNull();
            sut.Count.ShouldBe(4);
            sut.ElementAt(0).ShouldBe("   A");
            sut.ElementAt(1).ShouldBe("  B B");
            sut.ElementAt(2).ShouldBe(" C   C");
            sut.ElementAt(3).ShouldBe("D     D");
        }

        [Fact]
        public void Create_ShouldReturnSingleCharacterWhenInputIs_A()
        {
            //Arrange 
            const string expectedResult = "A";

            //Act
            string sut = Diamond.Create('A');

            //Assert
            sut.ShouldBe(expectedResult);
        }

        [Fact]
        public void Create_ShouldSucceddWhenInputIs_B()
        {
            //Arrange
            const string expectedResult = " A\n" +
                                          "B B\n" +
                                          " A";
            //Act
            string sut = Diamond.Create('B');

            //Assert
            sut.ShouldBe(expectedResult);
        }

        [Fact]
        public void Create_ShouldSucceddWhenInputIs_C()
        {
            //Arrange
            const string expectedResult = "  A\n" +
                                          " B B\n" +
                                          "C   C\n" +
                                          " B B\n" +
                                          "  A";
            //Act
            string sut = Diamond.Create('C');

            //Assert
            sut.ShouldBe(expectedResult);
        }


        [Fact]
        public void Create_ShouldSucceddWhenInputIs_D()
        {
            //Arrange
            const string expectedResult = "   A\n" +
                                          "  B B\n" +
                                          " C   C\n" +
                                          "D     D\n" +
                                          " C   C\n" +
                                          "  B B\n" +
                                          "   A";

            //Act
            string sut = Diamond.Create('D');

            //Assert
            sut.ShouldBe(expectedResult);
        }

    }
}
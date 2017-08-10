using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDIToJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            string edi = "ISA*00*          *00*          *ZZ*TX3344556677888*ZZ*CIG112233445566*111219*1340*^*00401*000001377*0*T*>~GS*HC*TX3344556677888*CIG112233445577*20111219*1340*1377*X*004010X222~ST*820*000000001~BPR*C*10000*C*ACH*CTX*01*1234*DA*555*CUSTID0001**01*987*DA*345123*19990101~TRN*1*1001983525~REF*CD*1234564114~REF*TN*1001983525~DTM*007*19990101~N1*PE*BURLINGTON NORTHERN SANTA FE~N1*PR*CUSTOMER NAME~ENT*1~RMR*WY*123456**2000~REF*D0*RATE AUTHORITY*PER ITEM 12121 RATE SHOULD BE $2000 PER CAR~REF*BM*1001~REF*EQ*BNSF456002~DTM*095*19990101~RMR*WY*999999**5000~REF*BM*1002~REF*EQ*BNSF458869~DTM*095*19990101~RMR*WY*999787**3000~REF*BM*1003~REF*EQ*BNSF458870~DTM*095*19990101~SE*23*0000000001 ~GE*1*1377~IEA*1*000001377~";
            string elementSeparator = edi.Substring(3, 1);
            string segmentSeparator = edi.Substring(105, 1);
            string subelementSeparator = edi.Substring(104, 1);

            string[] segments = edi.Split(System.Convert.ToChar(segmentSeparator));

            for (int i = 0; i < 10; i++ )
            {
                Console.WriteLine(segments[i]);
                Console.ReadLine();
            }

                
        }
    }
}

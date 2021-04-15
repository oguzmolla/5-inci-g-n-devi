using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager
    {
        /* Kredi türü taşıt ev ihtiyaç kredisi vb gibi şeylerin 
         * hesaplamaları ayrı olur hepsini bir hesapla methodun içinde yazarsak 
         karmaşık bir yapı olur o yüzden interface açarak
         her krediye özel hesapla methodu yazıcaz 
         
         interface leri birbirinin alternatifi olan ama kod içerikleri farklı olan
         durumlar için kullanırız.
         */
        public void Calculate();
    }
}

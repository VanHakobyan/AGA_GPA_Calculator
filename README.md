# AGA
### MOG(ՄՈԳ) Calculator
<p align="center">
<img  src="http://aparanblog.do.am/gif/AGAv1-5.gif">
</p>
</br>

```C#
for (int i = 0; i < 7; i++)
{

    if (ArrayCredit[i].ToString() != "" && ArrayPoint[i].ToString() !="" )
    {
        try
        {
            SumPoint += Convert.ToSingle(ArrayPoint[i]) * Convert.ToSingle(ArrayCredit[i]);
            LikPoint += Convert.ToSingle(ArrayPoint[i]);
        }
        catch (Exception)
        {
            MessageBox.Show("Մուտք է արված սխալ սիմվոլ !!!");
            goto L;
        }

    }
    else continue;
}
for (int i = 0; i < ArrayCredit.ToArray().Length; i++)
{
    if (ArrayCredit[i].ToString()!="")
    {
        try
        {
            SumCredit += Convert.ToSingle(ArrayCredit[i]);
        }
        catch (Exception)
        {
            MessageBox.Show("Մուտք է արված սխալ սիմվոլ !!!");
            goto L;
        }


    }
}
Calculator = SumPoint / SumCredit;
MessageBox.Show(Calculator.ToString());
 ```

* Ընդհանուր դրույթներ

2. Կրեդիտային համակարգի ընդհանուր նկարագիրը<br>

2.1. Կրեդիտային համակարգի հիմնադրույթները<br>
Համաեվրոպական ECTS1 կրեդիտային համակարգի հետևյալ սահմա-
նումները և դրույթները ընդունված են Հայաստանի բարձրագույն կրթու-
թյան համակարգում և գործում են ԵՊՀ բակալավրի և մագիստրոսի կրթա-
կան ծրագրերում։<br>
1. Կարողությունը գիտելիքի, իմացության և ունակությունների դինամիկ
համակցություն է, որի ձևավորումը կրթական ծրագրի հիմնական
նպատակն է։ Այն կարող է լինել մասնագիտական (առանձնահատուկ
ուսման տվյալ բնագավառի համար) և ընդհանուր։<br>
2. Կրթական արդյունքն այն է, ինչ պետք է գիտենա, հասկանա և (կամ)
կարողանա անել ուսանողն ուսումնառության ավարտին։ Կրթական
արդյունքը զուգակցվում է համապատասխան գնահատման չափանի-
շով, որը հնարավորություն է տալիս դատելու դասընթացով սահման-
ված կրթական արդյունքի ձեռքբերման վերաբերյալ։ Կրթական ար-
դյունքը և գնահատման չափանիշը միասին սահմանում են կրեդիտի
շնորհման պահանջները։<br>



<p align="center">
<img  src="https://i.gyazo.com/e24fc70dcb84141088b661de9a567814.png">
</p><br><br>


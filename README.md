<h3><p align="center"> AGA v1.5 WPF</p></h3>
<h4><p align="center"> MOG(ՄՈԳ) Calculator</p></h4></br>
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

* Կիրառությունը: 
AGA v1.5-ի միջոցով դուք կարող եք հաշվել  բարձրագույն ուսումնական հաստատության ձեր ընթացիկ ՄՈԳ-ը (Միջին որակավորման գնահատականը) հիմնվելով հիմնական առարկաներից ստացած գնահատականների և համապատասխան կրեդիտների վրա:

* Աշխատանքի սկզբունքը: 
Աշխատանքի համար անհրաժեշտ է լրացնել Գնահատական և Կրեդիտ տողերը համապատասխանաբար և սեղմել Հաշվիր ստեղնը:

<h4>Download</h4><br>
(Link 1)[http://aparanblog.do.am/aga/AGAv1.5.rar]
(Link 2)[https://drive.google.com/file/d/0By1MH5wlD0LhcE9mbXV2T0U0Zzg/view]
(Link 3)[https://www.dropbox.com/s/wt5uq1mnwqp7dpa/AGAv1.5.rar?dl=0]


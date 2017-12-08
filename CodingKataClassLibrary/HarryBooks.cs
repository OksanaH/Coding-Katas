using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKataClassLibrary
{
    
     public class HarryBooks
    {
        public int bookPrice = 8;
       
        private float GetPriceWithDiscount(int booksInSetQty)
        {
            float price = 0;
            float disc = 0;
            if (booksInSetQty != 0)
            {
                if (booksInSetQty == 2)
                    disc = float.Parse("0.05");
                if (booksInSetQty == 3)
                    disc = float.Parse("0.1");
                if (booksInSetQty == 4)
                    disc = float.Parse("0.2");
                if (booksInSetQty == 5)
                    disc = float.Parse("0.25");
                price = float.Parse((booksInSetQty * 8 - booksInSetQty * 8 * disc).ToString());
            }
            return price;
        }
        public string CalcCost(List<int[]> sets)
        {
            float cost = 0;
            foreach (var set in sets)
            {
                cost = cost + GetPriceWithDiscount(set.Where(s => s != 0).ToList().Count);
            }

            return cost.ToString("#0.00");
        }
        public string CalculateCostOfBasket (int[] booksInBasket)
        {
            string cost= "";

            List<int> listOfDuplBooksInBasket = CreateListOfDupBooksInBasket(booksInBasket);
            //number of volumes in duplicate sets qty e.g. 123, 123 => 3 -means there are 2 empty spaces , so can still add 2 books
            //work out how many array spaces can be filled in
          
           int qtyVolumesinDuplSets = listOfDuplBooksInBasket.Where(b => b == listOfDuplBooksInBasket.Max()).ToList().Count();
            List<int[]> sets = CreateBookSets(booksInBasket, qtyVolumesinDuplSets, listOfDuplBooksInBasket.Max());
            cost = CalcCost(sets);
            return cost;
        }
      
        public List<int[]> CreateBookSets(int[] booksInBasket, int placesInArrayToFill, int howManyArrays)
        {
            List<int[]> arrays = new List<int[]>();
            int[] booksInBasketTemp = new int[booksInBasket.Length];// {0,0,0,0,0,0,0,0 };
            booksInBasket.CopyTo(booksInBasketTemp, 0);

            //which numbers to fill
            List<int> whichSpacesToFill = new List<int>();

            List<int> listOfDuplBooksInBasket = CreateListOfDupBooksInBasket(booksInBasket);         
            
            var groups = booksInBasket.GroupBy(b => b).ToList();
            int count = listOfDuplBooksInBasket.Max();
            foreach (var group in groups)
            {
                if (group.ToList().Count == count)
                    whichSpacesToFill.Add(group.ElementAt(0));
            }
            //
            for (int j = 1; j <= howManyArrays; j++)
            {
                int[] setsArray = new int[] { 0, 0, 0, 0, 0 };
                for (int k = 0; k <=whichSpacesToFill.Max(); k++)
                {
                    if (k+1 <= whichSpacesToFill.Max() && whichSpacesToFill.Any(s=>s==k+1))
                    {
                        setsArray[k] = 1;
                        int exclude = Array.FindIndex(booksInBasketTemp, b => b == k + 1);
                        booksInBasketTemp[exclude] = 0;
                    }
                   
                }
                arrays.Add(setsArray);
            }
            int booksToAllocate = booksInBasketTemp.Where(b => b != 0).ToList().Count;
            do
                {
                        foreach (var ar in arrays)
                        {
                            for (int a = 0; a < ar.Length; a++)
                            {

                                int bookToInsert = booksInBasketTemp.Where(b => b != 0).FirstOrDefault();
                                if (ar[a] == 0 && bookToInsert == a + 1)
                                {
                                    ar[a] = 1;
                                    int exclude = Array.FindIndex(booksInBasketTemp, b => b == bookToInsert);
                                    if (exclude > -1)
                                        booksInBasketTemp[exclude] = 0;
                                        break;
                                }
                            }
                        }
                }
                while (booksInBasketTemp.Where(b => b == 0).ToList().Count < booksInBasket.ToList().Count);
            return arrays;
        }
        public List<int>CreateListOfDupBooksInBasket(int[] booksInBasket)
        {
            List<int> result = new List<int>();
            for (int i = 1; i <= 5; i++)
            {
                result.Add(booksInBasket.Where(b => b == i).ToList().Count);//creates list e.g. [2,2,2,1,1,]
            }
            return result;
        }
       
    }
}

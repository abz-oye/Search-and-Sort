using System;
using System.Collections.Generic;

namespace SearchSort
{
    class Program {
        
        static void BubbleSort(List<int> nums) { // Bubble sort algorithm that passes the unordered lsit as a parameter
            int t = 0; // *
            bool swapped; // variable to check whetther or not variables are sorted
            do { // do while so that the loop will iterate at least once before checking condition
                swapped = false;
                for (int i = 1; i < nums.Count-1; i++) { // loops for length of the list -1 so each previous item can be checked
                    if (nums[i-1] > nums[i]) { // checks to see if previous number is greater than number after it...
                        t = nums[i-1]; //*ensures the numebrs are swapped correctly
                        nums[i-1] = nums[i];
                        nums[i] = t; // ...if so, numbers should be swapped
                        swapped = true; // once this happens for all numbers then it has been swapped and the loop can stop
                    }
                }
            } while (swapped == false); // repeats this until the list is swapped

            string ordered = "\nHere's the ordered list: ";
            ordered = ordered + string.Join(", ", nums);
            Console.WriteLine(ordered); // outputs ordered list
        }

        static void InsertionsSort(List<int> nums) { // Insertion sort algorithm that passes the unordered lsit as a parameter
            for (int i = 0; i < nums.Count - 1; i++) {
                for (int j = i + 1; j > 0; j--) {
                    if (nums[j - 1] > nums[j])
                    {
                        int temp = nums[j - 1];
                        nums[j - 1] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            string ordered = "\nHere's the ordered list: ";
            ordered = ordered + string.Join(", ", nums);
            Console.WriteLine(ordered); // outputs ordered list
        }
        
        static void Main(string[] args) {
            Console.WriteLine("Enter the length of list: "); // Asks user to nter the number of items in the list to know how many times to ask for each number.
            int n = Convert.ToInt32(Console.ReadLine());
            int ans = 0;
            List<int> nums = new List<int>(); // Creates an empty list of new numbers

            for (int i = 1; i < n+1; i++) {
                Console.WriteLine($"\nEnter item number {i}: "); // Prompts the user to enter a number a certain amount of time.
                ans = Convert.ToInt32(Console.ReadLine()); 
                nums.Add(ans); // Collects answer from the user and adds it to empty list.
            }
            
            Console.WriteLine("Would you like to SEARCH or SORT this list."); // Asks the user if they want to search or sort the list
            string choice = Console.ReadLine();
            
            if (choice == "SORT") { // if the user selects sort they will have the option to sort by bubble or insertion search
                while (true) {
                    Console.WriteLine("\nWould you like to BUBBLE or INSERTION sort this list.");
                    string option = Console.ReadLine();
                    if (option == "BUBBLE") {
                        BubbleSort(nums);
                        break;
                    }
                    else if (option == "INSERTION") {
                        InsertionsSort(nums);
                        break;
                    }
                    else {
                        Console.WriteLine("Please chose one of the correct options");
                        continue;
                    }
                }
            } 

            Console.ReadLine();
        }
    }
}

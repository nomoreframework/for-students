

#include <iostream>
#include <vector>
#include <string>
using namespace std;
   void Prefix_func(string &substring, vector<unsigned> &pref_func);
   void search_pattern(vector<unsigned> &pref_func, string &text,string &input_substring);
   void Dispaly_Info(string &input_substring, string mesage_info);
int main()
{  
	string text = "aaabbaabbac";
	string input_substring = "abbaabba";
	vector<unsigned> pref_func;

	Prefix_func(input_substring, pref_func);
	search_pattern(pref_func, text, input_substring);
	return 0;
}

void Prefix_func(string &input_substring, vector<unsigned> &pref_func)
{
	if (input_substring.size() < 2) { cout << "fuck"; return; }
	unsigned i, j;
	i = 1;
	j = 0;
	pref_func.push_back(0);
	while (i < input_substring.size())
	{
		if (input_substring[i] == input_substring[j])
		{
			pref_func.push_back(j + 1);
			i++;
			j++;
		}
		else if (j == 0)
		{
			 pref_func.push_back(0); 
			 i++; 
		}
		else
		{
			j = pref_func[j - 1];
		}
	} 	
}
void search_pattern(vector<unsigned>& pref_func, string& text, string &input_substring)
{
	if (input_substring.size() > text.size())
	{
		string mesage = "Pattern more than what to look for in a template";
		Dispaly_Info(input_substring, mesage);
		return;
	}
	unsigned k, l;
	k = 0;
	l = 0;
	while (k < text.size())
	{
		if (input_substring[l] == text[k])
		{
			k++;
			l++;
			if (l == pref_func[input_substring.size() - 1] && input_substring[l] == text[k])
			{
				string mesage_suc = "Patern found!";
				Dispaly_Info(input_substring, mesage_suc);
				return;
			}
		}
		else if (l == 0)
		{
			k++;		
		}
		else
		{
			if (k == text.size() - 1)
			{
				string mesage_no = "patern not found";
				Dispaly_Info(input_substring, mesage_no);
				return;
			}
			l = pref_func[l - 1];
		}
	}

}
void Display_Info(string &input_substring, string mesage_info)
{
	cout << input_substring << "\t" << mesage_info << endl;
}


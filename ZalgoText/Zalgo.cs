using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This is a port of the Zalgo text generator at http://eeemo.net/. 

namespace ZalgoText
{
    public class Zalgo
    {
        // data set of leet unicode chars
        //---------------------------------------------------

        //those go UP
        char[] zalgo_up = {
            '\u030d', /*     ̍     */		'\u030e', /*     ̎     */		'\u0304', /*     ̄     */		'\u0305', /*     ̅     */
            '\u033f', /*     ̿     */		'\u0311', /*     ̑     */		'\u0306', /*     ̆     */		'\u0310', /*     ̐     */
            '\u0352', /*     ͒     */		'\u0357', /*     ͗     */		'\u0351', /*     ͑     */		'\u0307', /*     ̇     */
            '\u0308', /*     ̈     */		'\u030a', /*     ̊     */		'\u0342', /*     ͂     */		'\u0343', /*     ̓     */
            '\u0344', /*     ̈́     */		'\u034a', /*     ͊     */		'\u034b', /*     ͋     */		'\u034c', /*     ͌     */
            '\u0303', /*     ̃     */		'\u0302', /*     ̂     */		'\u030c', /*     ̌     */		'\u0350', /*     ͐     */
            '\u0300', /*     ̀     */		'\u0301', /*     ́     */		'\u030b', /*     ̋     */		'\u030f', /*     ̏     */
            '\u0312', /*     ̒    */		'\u0313', /*     ̓     */		'\u0314', /*     ̔     */		'\u033d', /*     ̽     */
            '\u0309', /*     ̉     */		'\u0363', /*     ͣ     */		'\u0364', /*     ͤ     */		'\u0365', /*     ͥ     */
            '\u0366', /*     ͦ     */		'\u0367', /*     ͧ     */		'\u0368', /*     ͨ     */		'\u0369', /*     ͩ     */
            '\u036a', /*     ͪ     */		'\u036b', /*     ͫ     */		'\u036c', /*     ͬ     */		'\u036d', /*     ͭ     */
            '\u036e', /*     ͮ     */		'\u036f', /*     ͯ     */		'\u033e', /*     ̾     */		'\u035b', /*     ͛     */
            '\u0346', /*     ͆     */		'\u031a'  /*     ̚     */
        };

        //those go DOWN
        char[] zalgo_down = {
            '\u0316', /*     ̖     */		'\u0317', /*     ̗     */		'\u0318', /*     ̘     */		'\u0319', /*     ̙     */
            '\u031c', /*     ̜     */		'\u031d', /*     ̝     */		'\u031e', /*     ̞     */		'\u031f', /*     ̟     */
            '\u0320', /*     ̠     */		'\u0324', /*     ̤     */		'\u0325', /*     ̥     */		'\u0326', /*     ̦     */
            '\u0329', /*     ̩     */		'\u032a', /*     ̪     */		'\u032b', /*     ̫     */		'\u032c', /*     ̬     */
            '\u032d', /*     ̭     */		'\u032e', /*     ̮     */		'\u032f', /*     ̯     */		'\u0330', /*     ̰     */
            '\u0331', /*     ̱     */		'\u0332', /*     ̲     */		'\u0333', /*     ̳     */		'\u0339', /*     ̹     */
            '\u033a', /*     ̺     */		'\u033b', /*     ̻     */		'\u033c', /*     ̼     */		'\u0345', /*     ͅ     */
            '\u0347', /*     ͇     */		'\u0348', /*     ͈     */		'\u0349', /*     ͉     */		'\u034d', /*     ͍     */
            '\u034e', /*     ͎     */		'\u0353', /*     ͓     */		'\u0354', /*     ͔     */		'\u0355', /*     ͕     */
            '\u0356', /*     ͖     */		'\u0359', /*     ͙     */		'\u035a', /*     ͚     */		'\u0323'  /*     ̣     */
        };

        //those always stay in the middle
        char[] zalgo_mid = { 
            '\u0315', /*     ̕     */		'\u031b', /*     ̛     */		'\u0340', /*     ̀     */		'\u0341', /*     ́     */
            '\u0358', /*     ͘     */		'\u0321', /*     ̡     */		'\u0322', /*     ̢     */		'\u0327', /*     ̧     */
            '\u0328', /*     ̨     */		'\u0334', /*     ̴     */		'\u0335', /*     ̵     */		'\u0336', /*     ̶     */
            '\u034f', /*     ͏     */		'\u035c', /*     ͜     */		'\u035d', /*     ͝     */		'\u035e', /*     ͞     */
            '\u035f', /*     ͟     */		'\u0360', /*     ͠     */		'\u0362', /*     ͢     */		'\u0338', /*     ̸     */
            '\u0337', /*     ̷     */		'\u0361', /*     ͡     */		'\u0489'  /*     ҉_     */
        };

        // rand funcs
        //---------------------------------------------------

        Random r = new Random(); // Need to reuse this.
        //gets an int between 0 and max
        int rand(int max)
        {
            return r.Next(0, max);
        }

        //gets a random char from a zalgo char table
        char rand_zalgo(char[] array)
        {
            int index = r.Next(0, array.Length);
            return array[index];
        }


        // utils funcs
        //---------------------------------------------------

        //lookup char to know if its a zalgo char or not
        bool is_zalgo_char(char c)
        {
            for (int i = 0; i < zalgo_up.Length; i++)
                if (c == zalgo_up[i])
                    return true;
            for (int i = 0; i < zalgo_down.Length; i++)
                if (c == zalgo_down[i])
                    return true;
            for (int i = 0; i < zalgo_mid.Length; i++)
                if (c == zalgo_mid[i])
                    return true;
            return false;
        }

        // Zalgo options
        //---------------------------

        /// <summary>
        /// Mini fuck up
        /// </summary>
        public bool zalgo_opt_mini = false;
        /// <summary>
        /// Normal fuck up
        /// </summary>
        public bool zalgo_opt_normal = true;
        /// <summary>
        /// Maximum fuck up
        /// </summary>
        public bool zalgo_opt_max = false;

        /// <summary>
        /// Fuck going up
        /// </summary>
        public bool zalgo_opt_up = true;
        /// <summary>
        /// Fuck the middle
        /// </summary>
        public bool zalgo_opt_mid = true;
        /// <summary>
        /// Fuck going down
        /// </summary>
        public bool zalgo_opt_down = true;

        // main shit
        //---------------------------------------------------
        /// <summary>
        /// Pass in some text and get back some Zalgo text.
        /// </summary>
        /// <param name="txt">The string you want to Zalgify.</param>
        /// <returns>The fucked up, creepy Zalgo text string.</returns>
        public string ZalgoText(string txt)
        {
            string newtxt = string.Empty;

            for (int i = 0; i < txt.Length; i++)
            {
                if (is_zalgo_char(txt.Substring(i, 1).ToCharArray()[0]))
                    continue;

                int num_up;
                int num_mid;
                int num_down;

                //add the normal character
                newtxt += txt.Substring(i, 1);

                //options
                if (zalgo_opt_mini)
                {
                    num_up = rand(8);
                    num_mid = rand(2);
                    num_down = rand(8);
                }
				else if (zalgo_opt_normal)
                {
                    num_up = rand(16) / 2 + 1;
                    num_mid = rand(6) / 2;
                    num_down = rand(16) / 2 + 1;
                }
				else //maxi
				{
                    num_up = rand(64) / 4 + 3;
                    num_mid = rand(16) / 4 + 1;
                    num_down = rand(64) / 4 + 3;
                }


                if (zalgo_opt_up)
                {
                    for (int j = 0; j < num_up; j++)
                    {
                        newtxt += rand_zalgo(zalgo_up);
                    }
                }
                if (zalgo_opt_mid)
                {
                    for (var j = 0; j < num_mid; j++)
                    {
                        newtxt += rand_zalgo(zalgo_mid);
                    }
                }
                if (zalgo_opt_down)
                {
                    for (var j = 0; j < num_down; j++)
                    {
                        newtxt += rand_zalgo(zalgo_down);
                    }
                }
             }

            //result is in newtxt, display that
            return newtxt;
        }





                    }
}

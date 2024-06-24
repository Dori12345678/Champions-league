using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Champions_league
{
    public partial class memorable_matches : System.Web.UI.Page
    {
        Dictionary<string, int> matches = new Dictionary<string, int>()
{
    { "Manchester United vs. Bayern Munich: The 1999 Champions League final saw Manchester United score two late goals in injury time to defeat Bayern Munich 2-1 in one of the most dramatic finals in history.", 1999 },
    { "Liverpool vs. AC Milan: Known as the 'Miracle of Istanbul,' Liverpool came back from a 3-0 deficit at halftime to win the final against AC Milan on penalties in 2005.", 2005 },
    { "Barcelona vs. PSG: Barcelona completed an incredible comeback, overturning a 4-0 first-leg deficit by winning 6-1 at the Camp Nou to advance to the next round in 2017.", 2017 },
    { "Real Madrid vs. Atletico Madrid: Real Madrid won 'La Decima' (their 10th European title) in dramatic fashion, with Sergio Ramos scoring a last-minute equalizer before Real Madrid won 4-1 in extra time in 2014.", 2014 },
    { "Ajax vs. Tottenham Hotspur: In the semi-final second leg in 2019, Tottenham came back from a 2-0 deficit with a hat-trick from Lucas Moura, including a last-minute goal to advance to the final on away goals.", 2019 },
    { "Manchester City vs. Real Madrid: Real Madrid completed an astonishing comeback in the semi-final of 2022, scoring twice in the final minutes to take the game to extra time, and then winning it to reach the final.", 2022 },
    { "AC Milan vs. Liverpool: In a rematch of the 2005 final, AC Milan avenged their previous defeat with a 2-1 victory over Liverpool in 2007, with Filippo Inzaghi scoring both goals for Milan.", 2007 },
    { "Chelsea vs. Bayern Munich: In a dramatic final held at Bayern's home stadium in 2012, Chelsea equalized late through Didier Drogba and went on to win their first Champions League title on penalties.", 2012 },
    { "Barcelona vs. Manchester United: Barcelona delivered a masterclass performance in the final at Wembley in 2011, defeating Manchester United 3-1 with goals from Pedro, Messi, and Villa.", 2011 },
    { "Porto vs. Monaco: Under the management of José Mourinho, Porto triumphed 3-0 over Monaco in the final of 2004, marking a memorable and somewhat unexpected victory.", 2004 },
    { "Borussia Dortmund vs. Malaga: Dortmund scored twice in injury time to turn a 2-1 deficit into a 3-2 victory, advancing to the semi-finals in one of the most dramatic finishes in Champions League history in 2013.", 2013 }
};

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList.Items.Clear();
                foreach (KeyValuePair<string, int> item in matches)
                {
                    DropDownList.Items.Add(new ListItem(item.Value.ToString(), item.Value.ToString()));
                }
            }
        }

        protected void onSearch(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, int> item in matches)
            {
                if(item.Value == int.Parse(DropDownList.SelectedValue))
                {
                    Label text = new Label();
                    ButtonPlaceHolder.Controls.Add(text);
                    text.Text = item.Key;
                    text.ForeColor = System.Drawing.Color.White;
                }
            }
        }
    }
}
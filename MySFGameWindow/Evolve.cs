using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace MySFGameWindow
{
  public partial class Evolve : Form
  {
    int evolve;
    int counterLevel;

    public Evolve()
    {
      InitializeComponent();
    }

    private void EvolveBTN_Click(object sender, EventArgs e)
    {
      List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
      List<string> playerScore = new List<string>(File.ReadAllLines("scoreP.txt"));
      List<string> playerLevel = new List<string>(File.ReadAllLines("levelP.txt"));
      List<string> playerMush = new List<string>(File.ReadAllLines("mushP.txt"));
      List<string> playerPower = new List<string>(File.ReadAllLines("powerP.txt"));
      List<string> remainTimeP = new List<string>(File.ReadAllLines("remainTimeP.txt"));
      List<string> floorP = new List<string>(File.ReadAllLines("floorP.txt"));
      List<string> bossHP = new List<string>(File.ReadAllLines("bossHP.txt"));
      List<string> pictureCharP = new List<string>(File.ReadAllLines("pictureCharP.txt"));
      List<string> charP = new List<string>(File.ReadAllLines("charP.txt"));
      List<string> plusDamage = new List<string>(File.ReadAllLines("plusDamageP.txt"));
      List<string> weaponBuyName = new List<string>(File.ReadAllLines("weaponBuyName.txt"));
      List<string> weaponDaysRemain = new List<string>(File.ReadAllLines("weaponDaysP.txt"));
      List<string> evolveP = new List<string>(File.ReadAllLines("evolveP.txt"));
      List<string> countLevel = new List<string>(File.ReadAllLines("countLevel.txt"));
      List<string> wood = new List<string>(File.ReadAllLines("wood.txt"));
      List<string> stone = new List<string>(File.ReadAllLines("stone.txt"));
      List<string> wool = new List<string>(File.ReadAllLines("wool.txt"));

      List<string> sell = new List<string>(File.ReadAllLines("sell.txt"));

      List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
      int selected = int.Parse(playerSelect[0]);

    back:
      try
      {
        int counter = 0;
        foreach (var item in sell)
        {
          string[] data = item.Split(';');

          if (data[1] == playerSelect[0])
          {
            sell.RemoveAt(counter);
            File.WriteAllLines("sell.txt", sell.ToArray());
            goto back;
          }
          counter++;
        }
      }
      catch (Exception)
      {
      }

      counterLevel = int.Parse(countLevel[selected]);
      int actuallEvolve = int.Parse(evolveP[selected]);
      evolve = actuallEvolve + 1;
      counterLevel++;

      try
      {
        playerMoney.RemoveAt(selected);
        playerMoney.Insert(selected, "0");

        playerScore.RemoveAt(selected);
        playerScore.Insert(selected, "0");

        playerLevel.RemoveAt(selected);
        playerLevel.Insert(selected, "1");

        playerMush.RemoveAt(selected);
        playerMush.Insert(selected, "0");

        playerPower.RemoveAt(selected);
        playerPower.Insert(selected, "1");

        remainTimeP.RemoveAt(selected);
        remainTimeP.Insert(selected, "0");

        floorP.RemoveAt(selected);
        floorP.Insert(selected, "1");

        bossHP.RemoveAt(selected);
        bossHP.Insert(selected, "50");

        // Need A Change Road
        try
        {
          if (evolve >= 5)
          {
            pictureCharP.RemoveAt(selected);
            pictureCharP.Insert(selected, "paladin.png");
          }
          else
          {
            pictureCharP.RemoveAt(selected);
            pictureCharP.Insert(selected, "lord.png");
          }
        }
        catch (Exception)
        {
        }

        charP.RemoveAt(selected);
        charP.Insert(selected, "Paladin");

        evolveP.RemoveAt(selected);
        evolveP.Insert(selected, evolve.ToString());

        plusDamage.RemoveAt(selected);
        plusDamage.Insert(selected, "0");

        weaponBuyName.RemoveAt(selected);
        weaponBuyName.Insert(selected, "Null");

        weaponDaysRemain.RemoveAt(selected);
        weaponDaysRemain.Insert(selected, "0");

        countLevel.RemoveAt(selected);
        countLevel.Insert(selected, counterLevel.ToString());

        wood.RemoveAt(selected);
        wood.Insert(selected, "0");

        stone.RemoveAt(selected);
        stone.Insert(selected, "0");

        wool.RemoveAt(selected);
        wool.Insert(selected, "0");
      }
      catch (Exception)
      {
      }

      File.WriteAllLines("moneyP.txt", playerMoney.ToArray());
      File.WriteAllLines("scoreP.txt", playerScore.ToArray());
      File.WriteAllLines("levelP.txt", playerLevel.ToArray());
      File.WriteAllLines("mushP.txt", playerMush.ToArray());
      File.WriteAllLines("powerP.txt", playerPower.ToArray());
      File.WriteAllLines("remainTimeP.txt", remainTimeP.ToArray());
      File.WriteAllLines("bossHP.txt", bossHP.ToArray());
      File.WriteAllLines("pictureCharP.txt", pictureCharP.ToArray());
      File.WriteAllLines("charP.txt", charP.ToArray());
      File.WriteAllLines("evolveP.txt", evolveP.ToArray());
      File.WriteAllLines("floorP.txt", floorP.ToArray());
      File.WriteAllLines("plusDamageP.txt", plusDamage.ToArray());
      File.WriteAllLines("weaponBuyName.txt", weaponBuyName.ToArray());
      File.WriteAllLines("weaponDaysP.txt", weaponDaysRemain.ToArray());
      File.WriteAllLines("countLevel.txt", countLevel.ToArray());
      File.WriteAllLines("wood.txt", wood.ToArray());
      File.WriteAllLines("stone.txt", stone.ToArray());
      File.WriteAllLines("wool.txt", wool.ToArray());

      Form inv = Application.OpenForms["Inventory"];
      if (inv != null) Application.OpenForms["Inventory"].Close();

      if (evolve < 5) MessageBox.Show("Úspěšně jste resetovali své staty. nyní jste 'Lord' \n\nNyní se prosím opět přihlašte");
      else MessageBox.Show("Úspěšně jste resetovali své staty. nyní jste 'Paladin' \n\nNyní se prosím opět přihlašte");

      this.Close();
      SelectForm select = new SelectForm();
      select.Show();
    }

    private void backBTN_Click(object sender, EventArgs e)
    {
      this.Close();
      Menu menu = new Menu();
      menu.Show();
    }

    private void Evolve_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (Evolve.ModifierKeys == Keys.Alt || Evolve.ModifierKeys == Keys.F4) e.Cancel = true;
    }
  }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{   
    public void DestroyBase()
    {
        DataSave.Save save = new DataSave.Save();
        save.SetLevel(1);
        if (save.GetCompany() > 5)
        {
            save.SetCompany(1);
            save.SetLevel(-4);
        }
        SceneManager.LoadScene("Win");
    }
}

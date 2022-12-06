using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : ZumaElement
{
    public void Rotatelauncher() 
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Camera.main.transform.position.y)) 
        {
            app.launcherModel.lookDir = hit.point;
        }
        app.launcherModel.dir = app.launcherModel.lookDir -  app.launcherView.launcher.transform.position;
        app.launcherModel.dir.y = 0;
        app.launcherView.launcher.transform.LookAt(app.launcherView.launcher.transform.position + app.launcherModel.dir, Vector3.up);
    }
    public void SetBallPosition() 
    {
        app.launcherModel.currentBall.transform.forward = app.launcherView.launcher.transform.forward;
        app.launcherModel.currentBall.transform.position = app.launcherView.launcher.transform.position + app.launcherView.launcher.transform.forward * app.launcherView.launcher.transform.localScale.z;
    }
    public void CreateBall()
    {
        int index = Random.Range(0, app.launcherModel.ballPrefab.Length);
        app.launcherModel.currentBall = Instantiate(app.launcherModel.ballPrefab[index], transform.position, Quaternion.identity);
        app.launcherModel.currentBall.SetActive(true);
        app.launcherModel.currentBall.tag = "NewBall";
        app.launcherModel.currentBall.gameObject.layer = LayerMask.NameToLayer("Default");
    }

    public void ShootBall() 
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            app.launcherModel.currentBall.GetComponent<Rigidbody>().AddForce(app.launcherModel.currentBall.transform.forward * app.launcherModel.speed);
            CreateBall();
        }

    }

    private void Start()
    {
        CreateBall();
    }
    private void Update()
    {
        Rotatelauncher();
        SetBallPosition();
        ShootBall();
    }
}

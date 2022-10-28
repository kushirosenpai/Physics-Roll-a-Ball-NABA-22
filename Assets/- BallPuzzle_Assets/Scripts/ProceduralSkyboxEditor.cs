using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralSkyboxEditor : MonoBehaviour
{

    [Range(0, 1)] public float SunSize;
    [Range(0, 10)] public float SunSizeConvergence;
    [Range(0, 5)] public float AtmosphereThickness;
    public Color SkyTint;
    public Color GroundColor;
    [Range(0, 8)] public float Exposure;

    public GameObject DirectionalLight;
    public Vector3 SunRotation;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        RenderSettings.skybox.SetFloat("_SunSize", SunSize);
        RenderSettings.skybox.SetFloat("_SunSizeConvergence", SunSizeConvergence);
        RenderSettings.skybox.SetFloat("_AtmosphereThickness", AtmosphereThickness);
        RenderSettings.skybox.SetColor ("_SkyTint", SkyTint);
        RenderSettings.skybox.SetColor("_GroundColor", GroundColor);
        RenderSettings.skybox.SetFloat("_Exposure", Exposure);

        DirectionalLight.transform.Rotate(SunRotation);

    }
}

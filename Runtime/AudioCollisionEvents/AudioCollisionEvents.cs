using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCollisionEvents : MonoBehaviour {
    public BodyCollisionEvents events;
    public AudioData collision_audio;

    private void OnEnable() {
        this.events.on_collision_enter += OnBallCollisionEnter;
    }

    private void OnDisable() {
        this.events.on_collision_enter -= OnBallCollisionEnter;
    }

    private void OnBallCollisionEnter(BodyCollisionEvents events, Collision collision) {
        PostKickBall ball = collision.gameObject.GetComponent<PostKickBall>();
        if (ball) {
            MainSystem main_system = MainSystem.Get();
            Audio2DPlayer audio_player = main_system.Component<Audio2DPlayer>();
            audio_player.Play(this.collision_audio);
        }
    }
}

import React from "react";
import { useEffect, useState } from "react";
import { Track } from "./Track";
import "./Playlist.css"

export const Playlist = () => {

    const playList = { name: "bully", description: "riot fest" }
    const trackArr = [
        {
            id: 1,
            name: "Trying",
            bpm: 120,
            Notes: "don't rush",
            userProfileId: 1,
            BandId: 1,
            runTime: "00:03:20"
        },
        {
            id: 1,
            name: "Don't Stop",
            bpm: 155,
            Notes: "don't rush",
            userProfileId: 1,
            BandId: 1,
            runTime: "00:03:20"
        },
        {
            id: 1,
            name: "Can't Stop This Way",
            bpm: 190,
            Notes: "don't rush",
            userProfileId: 1,
            BandId: 1,
            runTime: "00:03:20"
        }
    ]



    return (
        <div className="playlistContainer">
            <div className="playList">
                <div className="bandName">
                    <span>{playList.name}</span>
                </div>
                <div className="playListDescription">
                    <span>{playList.description}</span>
                </div>
                <div>
                    {trackArr.map(track => (
                        <Track track={track} key={track.id} />
                    ))}
                </div>
            </div>
        </div>
    )
}
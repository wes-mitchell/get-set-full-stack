import React from "react";
import { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import './Track.css'

export const Track = () => {
    const [track, setTrack] = useState({
        id: 1,
        name: "Trying",
        bpm: 120,
        Notes: "don't rush",
        userProfileId: 1,
        BandId: 1,
        runTime: "00:03:20"
    })

    return (
        <div className="trackContainer">
            <div className="trackName">
                <span>{track.name}</span>
            </div>
            <div className="trackBpm">
                <span>{track.bpm} BPM</span>
            </div>
        </div>

    )
}
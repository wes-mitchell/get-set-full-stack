import React from "react";
import { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import './Track.css'

export const Track = ({ track }) => {

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
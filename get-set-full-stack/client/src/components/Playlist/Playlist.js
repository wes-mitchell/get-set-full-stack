import React from "react";
import { useEffect, useState } from "react";
import { Track } from "./Track";
import { getTracksByPlaylistId } from "../../modules/trackManager";
import "./Playlist.css"

export const Playlist = ({ playlist }) => {
    const [tracks, setTracks] = useState([])

    const getTracks = () => {
        getTracksByPlaylistId(playlist.id)
            .then(res => setTracks(res))
    }
    useEffect(() => {
        getTracks()
    }, [])

    return (
        <div className="playListContainer">
            <div className="playList">
                <div className="bandName">
                    <span>{playlist.bandName}</span>
                </div>
                <div className="playListDescription">
                    <span>{playlist.description}</span>
                </div>
                <div>
                    {tracks.map(track => (
                        <Track track={track} key={track.id} />
                    ))}
                </div>
            </div>
        </div>
    )
}
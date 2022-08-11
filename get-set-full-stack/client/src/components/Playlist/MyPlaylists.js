import React from "react";
import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { getPlaylistsByUserId } from "../../modules/playlistManager";
import { Playlist } from "./Playlist"

export const MyPlaylists = () => {
    const [playlists, setPlaylists] = useState([])
    const navigate = useNavigate()

    const getPlaylists = () => {
        getPlaylistsByUserId()
            .then(playlists => setPlaylists(playlists))
    }

    useEffect(() => {
        getPlaylists()
    }, [])

    return (
        <div className="userListContainer">
            <div className="usersPlaylists">
                {playlists.map(playlist => (
                    <Playlist playlist={playlist} key={playlist.id} />
                ))}
            </div>
        </div>
    )
}
import { getToken } from "./authManager";

const baseUrl = "/api/Playlist"

export const getPlaylistsByUserId = () => {
    return getToken().then((token) => {
        return fetch(`${baseUrl}/userplaylists`, {
            method: "GET",
            headers: {
                Authorization: `Bearer ${token}`,
            },
        }).then((res) => {
            if (res.ok) {
                return res.json()
            } else {
                throw new Error(
                    "An unknown error occurred while trying to retrieve the users playlists."
                )
            }
        })
    })
}
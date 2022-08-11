import { getToken } from "./authManager";
const baseUrl = "api/Track"

export const getTracksByPlaylistId = (id) => {
    return getToken().then((token) => {
        return fetch(`${baseUrl}/playlist/${id}`, {
            method: "GET",
            headers: {
                Authorization: `Bearer ${token}`,
            },
        }).then((res) => {
            if (res.ok) {
                return res.json()
            } else {
                throw new Error(
                    "An unknown error occurred while trying to retrieve the tracks for playlist."
                )
            }
        })
    })
}
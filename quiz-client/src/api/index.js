import axios from "axios";

export const BASE_URL = "http://localhost:5041/";

export const createAPIEndpoint = (endpoint) => {
  let Url = BASE_URL + "api/" + endpoint + "/";
  return {
    fetch: () => axios.get(Url),
    fetchById: (id) => axios.get(Url + id),
    post: (newRecord) => axios.post(Url, newRecord),
    put: (id, updatedRecord) => axios.put(Url + id, updatedRecord),
    delete: (id) => axios.delete(Url + id),
  };
};

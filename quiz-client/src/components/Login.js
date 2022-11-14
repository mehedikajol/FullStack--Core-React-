import React from "react";
import { Box, Button, TextField } from "@mui/material";

export default function Login() {
  return (
    <Box
      sx={{
        "& .MuiTextField-root": {
          m: 1,
          width: "90%",
        },
      }}
    >
      <form noValidate autoComplete="false">
        <TextField label="Email" name="email" variant="outlined" />
        <TextField label="Name" name="name" variant="outlined" />
        <Button
          type="submit"
          variant="contained"
          size="large"
          sx={{ width: "90%" }}
        >
          Start
        </Button>
      </form>
    </Box>
  );
}

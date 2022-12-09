<template>
  <v-container fluid>
    <v-form class="form-login" v-model="valid">
      <v-text-field v-model="name" :rules="nameRules" :counter="10" label="Nama" required></v-text-field>
      <v-text-field v-model="email" :rules="emailRules" label="E-mail" required></v-text-field>
      <v-textarea v-model="pesan" label="Pesan"></v-textarea>
    </v-form>
  </v-container>
</template>

<script>
  export default {
    data() {
      return {
        valid: false,
        name: "",
        nameRules: [
          v => !!v || 'Name is required',
          v => v.length <= 10 || 'Name must be least than 10 characters'
        ],
        email: "",
        emailRules: [
          v => !!v || 'E-mail is required',
          v => /.+@.+/.test(v) || 'E-mail must be valid'
        ],
        pesan: ""
      }
    }
  }
</script>

<style>
  .form-login {
    margin: auto;
    width: 40%;
    padding: 25px;
    margin-top: 40px;
    box-shadow: 0 0.5rem 1rem rgba(0, 0, 0, 0.20) !important;
    border-radius: 8px;
  }
</style>
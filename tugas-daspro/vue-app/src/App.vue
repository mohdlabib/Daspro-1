<template>
  <v-app>
    <v-main>
      <img src="./assets/logounri.png" height="75" width="330">
      <web-toolbar></web-toolbar>
      <router-view class="container" />
      <web-footer></web-footer>
    </v-main>
  </v-app>
</template>

<script>
  import WebToolbar from './components/WebToolbar.vue'
  import WebFooter from './components/WebFooter.vue'

  export default {
    name: 'App',
    components: {
      WebToolbar,
      WebFooter
    },
  };
</script>

<style>
  .container {
    padding: 20px;
  }

  .light {
    background-color: transparent !important;
    box-shadow: none !important;
    margin-left: 15px;
    margin-right: 15px;
  }
  
  .n-under {
    text-decoration: none !important;
  }
</style>
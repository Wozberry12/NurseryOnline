import App from './LoginPage.svelte';

const app = new App({
	target: document.body,
	props: {
		name: 'Login'
	}
});

export default app;
